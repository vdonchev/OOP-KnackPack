namespace KnackPack.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Utils;

    public class Knackpack : IKnackpack
    {
        private const double DefaultCapacity = 20;

        private readonly IList<IItem> items = new List<IItem>();
        private double capacity;

        public Knackpack(double capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
        }

        private double Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                Validators.NumberIsNegative(value, "Capacity");
                this.capacity = value;
            }
        }

        public IEnumerable<IItem> Items
        {
            get
            {
                return this.items;
            }
        }

        public void AddItem(IItem item)
        {
            if (item.Weight > this.Capacity)
            {
                throw new InvalidOperationException(Messages.CantAddItem);
            }

            this.items.Add(item);
            this.Capacity -= item.Weight;
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
            this.Capacity += item.Weight;
        }
        
        public bool FindItemByName(string itemName)
        {
            foreach (var it in this.items)
            {
                if (it.Name.Equals(itemName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}