namespace KnackPack.Interfaces
{
    using System.Collections.Generic;

    public interface IKnackpack
    {
        IEnumerable<IItem> Items { get; }

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        bool FindItemByName(string itemName);
    }
}