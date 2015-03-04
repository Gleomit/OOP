namespace TheSlum
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, Constants.HealerDefaultHealthPoints, Constants.HealerDefaultDefensePoints,
            team, Constants.HealerDefaultRange)
        {
            this.HealingPoints = Constants.HealerDefaultHealingPoints;
        }

        public int HealingPoints 
        { 
            get; 
            set;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            if (this.HealthPoints < 1 && item is Injection)
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
            List<Character> result = targetsList.OrderBy(target => target.HealthPoints)
                .Where(target=>target.Team == this.Team && target != this && target.IsAlive).ToList();
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
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
