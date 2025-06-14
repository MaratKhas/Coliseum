﻿using Coliseum.BuildingBlocks.Domain.Damages.Interfaces;
using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.BuildingBlocks.Domain.Ultimates;
using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;

namespace Coliseum.Modules.Coliseums.Domain.Bases
{
    public abstract class BaseWarrior : Entity, IDamageable
    {
        public BaseWarrior(int maxHealth)
        {
            MaxHealth = maxHealth;
            _health = MaxHealth;
        }

        protected Guid BattleId { get; private set; }

        public void SetBattleId(Guid idBattle)
        {
            BattleId = idBattle;
        }

        /// <summary>
        /// Имя бойца 
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Максимальное количество хп
        /// </summary>
        protected abstract int MaxHealth { get; set; }

        /// <summary>
        /// Атака бойца
        /// </summary>
        protected abstract BaseDamage Damage { get; set; }

        /// <summary>
        /// Защита от физических атак число от 0 до 1
        /// </summary>
        protected abstract double PhysicalDefense { get; }

        /// <summary>
        /// Защита от магических атак число от 0 до 1
        /// </summary>
        protected abstract double MagicalDefense { get; }

        public abstract object Clone();

        /// <summary>
        /// Текущее ХП бойца
        /// </summary>
        private int _health;

        /// <summary>
        /// Доступ к текущим ХП
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return _health;
        }

        /// <summary>
        /// Свойство жив ли боец
        /// </summary>
        public bool IsAlive => _health > 0;

        /// <summary>
        /// Интервал атак в миллисекундах
        /// </summary>
        public int FireRate { get; protected set; } = 1000;

        /// <summary>
        /// Дата последней атаки
        /// </summary>
        private DateTime _lastAttackTime = DateTime.MinValue;

        /// <summary>
        /// Готовность атаки
        /// </summary>
        public bool CanAttackNow => (DateTime.UtcNow - _lastAttackTime).TotalMilliseconds >= FireRate;

        /// <summary>
        /// лечит бойца на определенное количество HP
        /// </summary>
        /// <param name="heal">количество HP</param>
        protected void HealWarrior(int heal)
        {
            var healing = Math.Min(_health + heal, MaxHealth - _health);
            _health += healing;

            AddDomainEvent(new HealedEvent(BattleId, Id, healing));
        }

        /// <summary>
        /// Атака на оппонента
        /// так же на этом шаге используется атакующая ультимативная способность если она есть у бойца
        /// </summary>
        /// <param name="opponent"></param>
        public void Attack(IDamageable opponent)
        {
            if (!IsAlive || !CanAttackNow) return;

            opponent.GetDamage(Damage);

            AddDomainEvent(new AttackedEvent(BattleId, Id, opponent.Id, Damage));

            if (this is IHaveAttackUltimate<IUltimate> ultimate)
            {
                ultimate.UseUltimate();
            }
        }

        /// <summary>
        /// Принятие атаки 
        /// так же в этой методе используется хилящая ультимативная способность если она есть
        /// </summary>
        /// <param name="damage"></param>
        /// <exception cref="Exception"></exception>
        public void GetDamage(IDamage damage)
        {
            var damageTypeString = damage.DamageType.ToString();
            var damageValue = damage.GetDamageValue();

            switch (damage.DamageType)
            {
                case DamageType.Physical:
                    _health -= damageValue - (int)(damageValue * PhysicalDefense);
                    break;
                case DamageType.Magical:
                    _health -= damageValue - (int)(MagicalDefense * MagicalDefense);
                    break;
                case DamageType.Clear:
                    _health -= damageValue;
                    break;

                default:
                    throw new Exception("Данный тип демеджа не существует в системе, пожалуйста ознакомьтесь с файлом DamageTypeEnum.cs");
            }

            AddDomainEvent(new DamageTakenEvent(BattleId, Id, damageValue, damage.DamageType));

            if (_health <= 0)
            {
                _health = 0;
                AddDomainEvent(new DefeatedEvent(BattleId, Id));
            }
            else if (this is IHaveHealingUltimate<IUltimate> healingUltimate &&
                    _health < MaxHealth * 0.3)
            {
                healingUltimate.UseUltimate();
            }

        }

        /// <summary>
        /// Получение информации о бойце
        /// </summary>
        /// <returns></returns>
        public string GetWarriorInfo()
        {
            return $"{Name}, количество hp {MaxHealth} физ резист {PhysicalDefense} маг резист {MagicalDefense}";
        }
    }
}
