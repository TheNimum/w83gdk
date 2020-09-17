using System;

namespace w83gdk
{
    class Program
    {
        public enum Enum
            {
                Value1 = -100,
                Value2,
                Value3 = 100,
                Value4,
            }
        static void Main(string[] args)
        {
            
            Enum[] enums = {
                Enum.Value1, Enum.Value2,
                Enum.Value3, Enum.Value4
            };
            for (int i=0; i < enums.Length; ++i)
            {
                Console.WriteLine((int)enums[i]);
            }
        }
    }
}
