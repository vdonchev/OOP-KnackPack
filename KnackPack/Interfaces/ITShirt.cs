namespace KnackPack.Interfaces
{
    using Models.Items;

    public interface ITShirt : IWear
    {
        SleeveType SleeveType { get; }
    }
}