namespace KnackPack
{
    using System;
    using Interfaces;
    using Models;
    using Models.Items;

    public static class Program
    {
        public static void Main()
        {
            IKnackpack bag = new Knackpack(5);

            var iphone = new MobilePhone("iPhone", .250, "6S", true);
            var laptop = new Laptop("Acer", 2.380, "Aspire", 15);
            var shirt = new TShirt("Teniska", .500, 32, WearType.Male, "red", SleeveType.Long);
            iphone.ChangeState();

            bag.AddItem(iphone);
            bag.AddItem(laptop);
            bag.AddItem(shirt);

            foreach (var item in bag.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
