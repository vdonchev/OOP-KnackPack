namespace KnackPack.Interfaces
{
    public interface IMobilePhone : IElectronic
    {
        bool SwitchedOn { get; }

        void ChangeState();
    }
}