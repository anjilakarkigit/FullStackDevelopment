using System;
namespace ConsoleApp1
{
	public class BytesInMemory
	{
		public static void printMemory()
		{
            Console.WriteLine("Type: sbyte");
            Console.WriteLine("Size in bytes: {0}", sizeof(sbyte));
            Console.WriteLine("Min Value: {0}", sbyte.MinValue);
            Console.WriteLine("Max Value: {0}", sbyte.MaxValue);

            Console.WriteLine("\nType: byte");
            Console.WriteLine("Size in bytes: {0}", sizeof(sbyte));
            Console.WriteLine("Min Value: {0}", byte.MinValue);
            Console.WriteLine("Max Value: {0}", byte.MaxValue);

            Console.WriteLine("\nType: short");
            Console.WriteLine("Size in bytes: {0}", sizeof(short));
            Console.WriteLine("Min Value: {0}", short.MinValue);
            Console.WriteLine("Max Value: {0}", short.MaxValue);

            Console.WriteLine("\nType: ushort");
            Console.WriteLine("Size in bytes: {0}", sizeof(ushort));
            Console.WriteLine("Min Value: {0}", ushort.MinValue);
            Console.WriteLine("Max Value: {0}", ushort.MaxValue);

            Console.WriteLine("\nType: int");
            Console.WriteLine("Size in bytes: {0}", sizeof(int));
            Console.WriteLine("Min Value: {0}", int.MinValue);
            Console.WriteLine("Max Value: {0}", int.MaxValue);

            Console.WriteLine("\nType: uint");
            Console.WriteLine("Size in bytes: {0}", sizeof(uint));
            Console.WriteLine("Min Value: {0}", uint.MinValue);
            Console.WriteLine("Max Value: {0}", uint.MaxValue);

            Console.WriteLine("\nType: long");
            Console.WriteLine("Size in bytes: {0}", sizeof(long));
            Console.WriteLine("Min Value: {0}", long.MinValue);
            Console.WriteLine("Max Value: {0}", long.MaxValue);

            Console.WriteLine("\nType: ulong");
            Console.WriteLine("Size in bytes: {0}", sizeof(ulong));
            Console.WriteLine("Min Value: {0}", ulong.MinValue);
            Console.WriteLine("Max Value: {0}", ulong.MaxValue);

            Console.WriteLine("\nType: float");
            Console.WriteLine("Size in bytes: {0}", sizeof(float));
            Console.WriteLine("Min Value: {0}", float.MinValue);
            Console.WriteLine("Max Value: {0}", float.MaxValue);

            Console.WriteLine("\nType: double");
            Console.WriteLine("Size in bytes: {0}", sizeof(double));
            Console.WriteLine("Min Value: {0}", double.MinValue);
            Console.WriteLine("Max Value: {0}", double.MaxValue);

            Console.WriteLine("\nType: decimal");
            Console.WriteLine("Size in bytes: {0}", sizeof(decimal));
            Console.WriteLine("Min Value: {0}", decimal.MinValue);
            Console.WriteLine("Max Value: {0}", decimal.MaxValue);
        }

        //public static void Main()
        //{
        //    printMemory();
        //}

    }
}

