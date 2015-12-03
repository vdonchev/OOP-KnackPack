namespace KnackPack.Models.Items
{
    using Interfaces;
    using Utils;

    public abstract class Wear : Item, IWear
    {
        private double wearSize;
        private string wearColor;

        protected Wear(
            string name, 
            double weight, 
            double wearSize, 
            WearType wearType, 
            string wearColor)
            : base(name, weight)
        {
            this.WearSize = wearSize;
            this.WearType = wearType;
            this.wearColor = wearColor;
        }

        public double WearSize
        {
            get
            {
                return this.wearSize;
            }

            private set
            {
                Validators.NumberIsNegative(value, "Size");
                this.wearSize = value;
            }
        }

        public WearType WearType { get; private set; }

        public string WearColor
        {
            get
            {
                return this.wearColor;
            }

            set
            {
                Validators.StringIsNullOrEmpty(value, "Color");
                this.wearColor = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() 
                + $", Size: {this.WearSize}, Type: {this.WearType}, Color: {this.WearColor}";
        }
    }
}