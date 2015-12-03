namespace KnackPack.Models.Items
{
    using Interfaces;
    using Utils;

    public class Laptop : Electronic, ILaptop
    {
        private double screenSize;

        public Laptop(
            string name, 
            double weight, 
            string model,
            double screenSize) 
            : base(name, weight, model)
        {
            this.ScreenSize = screenSize;
        }

        public double ScreenSize
        {
            get
            {
                return this.screenSize;
            }

            private set
            {
                Validators.NumberIsNegative(value, "Screen size");
                this.screenSize = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + $", Screen size: {this.ScreenSize:F2}";
        }
    }
}