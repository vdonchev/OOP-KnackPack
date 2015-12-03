namespace KnackPack.Models.Items
{
    using Interfaces;
    using Utils;

    public abstract class Electronic : Item, IElectronic
    {
        private string model;

        protected Electronic(string name, double weight, string model) 
            : base(name, weight)
        {
            this.Model = model;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validators.StringIsNullOrEmpty(value, "Model");
                this.model = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() 
                + $", Model: {this.Model}";
        }
    }
}