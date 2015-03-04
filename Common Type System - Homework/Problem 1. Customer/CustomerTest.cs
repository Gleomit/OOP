namespace CommonTypeSystem.Customer
{
    using System;
    using System.Collections.Generic;

    public class CustomerTest
    {
        public static void Main()
        {
            Customer test = new Customer("temp", "haha", "tempp", 14423523, "d", "432"
                , "tertr33", new List<Payment>() { new Payment("haha", 10) });
            Customer test2 = test.Clone() as Customer;

            Console.WriteLine(string.Format("Customer != Cloned Customer = {0}", test != test2));
            Console.WriteLine(string.Format("Customer == Cloned Customer = {0}", test == test2));
            Console.WriteLine(string.Format("Customer.Equals(Cloned Customer) = {0}", test.Equals(test2)));
            Console.WriteLine(string.Format("Customer.CompareTo(Cloned Customer) = {0}", test.CompareTo(test2)));

            Console.WriteLine("Customers: ");
            Console.WriteLine(test.ToString());
            Console.WriteLine(test2.ToString());
            Console.Read();
        }
    }
}
