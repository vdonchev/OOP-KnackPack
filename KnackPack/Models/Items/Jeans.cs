namespace KnackPack.Models.Items
{
    public class Jeans : Wear
    {
        public Jeans(
            string name,
            double weight,
            double wearSize,
            WearType wearType,
            string wearColor)
            : base(name,
                  weight,
                  wearSize,
                  wearType,
                  wearColor)
        {
        }
    }
}