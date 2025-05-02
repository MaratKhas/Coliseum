using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Modules.Coliseums.Domain.Bases;
using Coliseum.Modules.Coliseums.Domain.BattleEvents;
using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;

namespace Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain
{
    public class BattleArea : Entity
    {
        private readonly List<BaseWarrior> _leftWarriors = new();

        private readonly List<BaseWarrior> _rightWarriors = new();

        private BattleState _state = BattleState.NotStarted;

        public IReadOnlyList<BaseWarrior> LeftWarriors => _leftWarriors.AsReadOnly();
        public IReadOnlyList<BaseWarrior> RightWarriors => _rightWarriors.AsReadOnly();
        public BattleState State => _state;

        protected BattleArea()
        {
            Id = Guid.NewGuid();
        }

        public static BattleArea Create()
        {
            return new BattleArea();
        }

        public void AddWarriorsToLeftWarriors(IEnumerable<BaseWarrior> warriors)
        {
            if (_state != BattleState.NotStarted)
                throw new InvalidOperationException("Битва уже начата, добавить бойцов не возможно");

            _leftWarriors.AddRange(warriors);
        }

        public void AddWarriorsToRightWarriors(IEnumerable<BaseWarrior> warriors)
        {
            if (_state != BattleState.NotStarted)
                throw new InvalidOperationException("Битва уже начата, добавить бойцов не возможно");

            _rightWarriors.AddRange(warriors);
        }

        public async Task StartBattleAsync(CancellationToken cancellationToken)
        {
            AddDomainEvent(new BattleStartedEvent(Id, DateTime.UtcNow));

            var battleLog = new List<string>();
            var battleTasks = new List<Task>();

            battleTasks.AddRange(
                _leftWarriors.Select(s => WarriorBattleLoop(s, _rightWarriors, battleLog, cancellationToken))
                );

            battleTasks.AddRange(
                _rightWarriors.Select(s => WarriorBattleLoop(s, _leftWarriors, battleLog, cancellationToken))
                );

            // Wait for battle completion
            await Task.WhenAll(battleTasks);

            // Determine result
            var winningTeam = _leftWarriors.Any(w => w.IsAlive) ? "TeamA" : "TeamB";
            var survivors = (winningTeam == "TeamA" ? _leftWarriors : _rightWarriors)
                .Where(w => w.IsAlive).ToList();

            AddDomainEvent(new BattleEndedEvent(Id, DateTime.UtcNow));
        }

        private async Task WarriorBattleLoop(BaseWarrior warrior, IReadOnlyCollection<BaseWarrior> enemies, IReadOnlyCollection<string> battleLog, CancellationToken cancellationToken)
        {
            using var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(warrior.FireRate));

            while (!cancellationToken.IsCancellationRequested &&
                   warrior.IsAlive &&
                   enemies.Any(e => e.IsAlive))
            {
                // Ждем следующего "тика" таймера
                await timer.WaitForNextTickAsync(cancellationToken);

                if (cancellationToken.IsCancellationRequested) break;

                var aliveEnemies = enemies.Where(e => e.IsAlive).ToList();
                if (!aliveEnemies.Any()) break;

                var target = aliveEnemies[Random.Shared.Next(aliveEnemies.Count)];
                warrior.Attack(target);
            }
        }
    }
}

