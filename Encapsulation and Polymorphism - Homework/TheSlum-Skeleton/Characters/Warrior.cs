namespace TheSlum
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    class Warrior : Character, IAttack
    {
        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, Constants.WarriorDefaultHealthPoints,
            Constants.WarriorDefaultDefensePoints, team, Constants.WarriorDefaultRange)
        {
            this.AttackPoints = Constants.WarriorDefaultAttackPoints;
        }

        public int AttackPoints
        {
            get;
            set;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
            if(this.HealthPoints < 1 && item is Injection)
            {
                this.HealthPoints = 1;
            }
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            if (item is Axe || item is Pill)
            {
                this.AttackPoints -= item.AttackEffect;
            }
            else if (this.HealthPoints < 1 && item is Injection)
            {
                this.HealthPoints = 1;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            List<Character> result = targetsList.Where(target => target.Team != this.Team && target != this && target.IsAlive).ToList();
            if (result.Count > 0)
            {
                return result.First();
            }
            else
            {
                return null;
            }
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            if (item is Axe || item is Pill)
            {
                this.AttackPoints += item.AttackEffect;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}
