using Coliseum.Domain.Bases;
using Coliseum.Domain.Damages;

namespace Coliseum.Domain.Warriors
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

        protected override int PhysicalDefense => 80;

        protected override int MagicalDefense => 10;

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
