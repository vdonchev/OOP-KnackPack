namespace KnackPack.Models.Items
{
    using Interfaces;

    public class TShirt : Wear, ITShirt
    {
        public TShirt(
            string name,
            double weight,
            double wearSize,
            WearType wearType,
            string wearColor,
            SleeveType sleeveType)
            : base(name,
                  weight,
                  wearSize,
                  wearType,
                  wearColor)
        {
            this.SleeveType = sleeveType;
        }

        public SleeveType SleeveType { get; private set; }

        public override string ToString()
        {
            return base.ToString() 
                + $", Sleeve: {this.SleeveType}";
        }
    }
}