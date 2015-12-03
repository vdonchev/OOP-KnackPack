namespace KnackPack.Interfaces
{
    public interface IElectronic : IItem
    {
        string Model { get; }

        void ChangeState();
    }
}