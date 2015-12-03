namespace KnackPack.Interfaces
{
    using Models.Items;

    public interface IWear : IItem
    {
        double WearSize { get; }

        WearType WearType { get; }

        string WearColor { get; set; }
    }
}