namespace KnackPack.Models.Items
{
    using Interfaces;

    public class MobilePhone : Electronic, IMobilePhone
    {
        public MobilePhone(
            string name, 
            double weight, 
            string model,
            bool hasScreen) 
            : base(name, weight, model)
        {
            this.HasScreen = hasScreen;
        }

        public bool HasScreen { get; private set; }

        public override string ToString()
        {
            return base.ToString()
                + $", HasScreen: {(this.HasScreen ? "Yes" : "No")}";
        }
    }
}