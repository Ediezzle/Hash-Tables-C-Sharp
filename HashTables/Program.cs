using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" }
                };

            //adding a key that already exists throws an error
            ht.Add(8.5F, 8.5);
            Console.WriteLine(ht[2]);
            Console.WriteLine(ht[2].GetType());
            Console.WriteLine(typeof(Hashtable));

            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            foreach (var key in ht.Keys)
                Console.WriteLine("Key:{0}, Value:{1}", key, ht[key]);

            Console.WriteLine("***All Values***");

            foreach (var value in ht.Values)
                Console.WriteLine("Value:{0}", value);

            ht.Remove("Fv"); // removes {"Fv", "Five"}

            ht.Contains(2);// returns true
            ht.ContainsKey(2);// returns true
            ht.Contains(5); //returns false
            ht.ContainsValue("One"); // returns true

            ht.Clear(); // removes all elements
            Console.WriteLine("Total Elements: {0}", ht.Count);
        }
    }
}
