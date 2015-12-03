namespace KnackPack.Utils
{
    using System;

    public static class Validators
    {
        public static void StringIsNullOrEmpty(string str, string title)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException(
                    string.Format(Messages.CantBeNullOrEmpty, title));
            }
        }

        public static void NumberIsNegative(dynamic num, string title)
        {
            if (num < 0)
            {
                throw new ArgumentException(
                    string.Format(Messages.CantBeNegative, title));
            }
        }
    }
}