namespace HomeworkStaticMembersAndNamespaces
{
    using System;

    class BitArrayTest
    {
        static void Main()
        { 
            BitArray bit = new BitArray(100000);
            bit[0] = 1;
            Console.WriteLine(bit.ToString());
            Console.ReadKey();
        }
    }
}
