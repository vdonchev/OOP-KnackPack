namespace KnackPack.Models.Items
{
    using Interfaces;

    public class MobilePhone : Electronic, IMobilePhone
    {
        public MobilePhone(
            string name, 
            double weight, 
            string model,
            bool swtichedOn) 
            : base(name, weight, model)
        {
            this.SwitchedOn = swtichedOn;
        }

        public bool SwitchedOn { get; private set; }

        public void ChangeState()
        {
            this.SwitchedOn = !this.SwitchedOn;
        }

        public override string ToString()
        {
            return base.ToString()
                + $", Status: {(this.SwitchedOn ? "On" : "Off")}";
        }
    }
}