using System;


namespace Codespace
{
    class Program
    {
        static void Main(string[] args)
        {
             string connectionString = "ConnectionString";

            string input = Console.ReadLine();
            
            {
                var query1 = "SELECT ITEM,PRICE FROM PRODUCT WHERE ITEM_CATEGORY='" + input + "' ORDER BY PRICE";
                Console.WriteLine("Completed");
                Console.WriteLine("Completed");
            } 
        }
    }

    class Sample
    {
        string Id { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
    }
}
