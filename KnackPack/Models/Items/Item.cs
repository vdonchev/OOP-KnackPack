namespace KnackPack.Models.Items
{
    using Interfaces;
    using Utils;

    public abstract class Item : IItem
    {
        private string name;
        private double weight;

        protected Item(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validators.StringIsNullOrEmpty(value, "Name");
                this.name = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                Validators.NumberIsNegative(value, "Weight");
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return $"[{this.GetType().Name}] {this.Name} ({this.Weight:F2})";
        }
    }
}