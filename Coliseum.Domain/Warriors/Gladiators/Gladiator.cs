using Coliseum.Modules.Coliseums.Domain.Bases;
using Coliseum.Modules.Coliseums.Domain.Damages;

namespace Coliseum.Modules.Coliseums.Domain.Warriors.Gladiators
{
    public class Gladiator : BaseWarrior
    {
        protected Gladiator(string name, int damage, int maxHealth) : base(maxHealth)
        {
            Name = name;
            Damage = new PhysicalDamage(damage);
        }

        protected override int MaxHealth { get; set; }

        protected override BaseDamage Damage { get; set; }

        protected override double PhysicalDefense => 0.8;

        protected override double MagicalDefense => 0.1;

        public override object Clone()
        {
            return new Gladiator(Name, Damage.DamageValue, MaxHealth);
        }

        public static Gladiator Create(string name, int damage, int maxHealth)
        {
            //todo : Проверки

            return new Gladiator(name, damage, maxHealth);
        }
    }
}
