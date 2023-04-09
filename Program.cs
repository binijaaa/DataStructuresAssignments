using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataStructuresThirdAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            //now we will be adding key value pairs (key, value)
            products.Add("Banana", 2);
            products.Add("Chocolate", 1);
            products.Add("Apples", 3);
            products.Add("Tomatoes", 1);
            products.Add("Pineapple", 2);
            products.Add("Bread", 1);
            products.Add("Milk", 6);
            products.Add("Yoghurt", 2);



            int LessThan1 = 0;
            int MinValue = products.Values.Min();
            int MaxValue = products.Values.Max();
            
            foreach (KeyValuePair<string, int> element in products) //remember that (key, value)
            {
                if (element.Value < 1)
                {
                    LessThan1++;
                }
            }

            Console.WriteLine("Count of elements that are less than 1 EUR: " + LessThan1);
            Console.WriteLine("Value of the cheapest product is: " + MinValue);
            Console.WriteLine("Value of the mot expensive product is: " + MaxValue);


            Dictionary<string, int> makeup = new Dictionary<string, int>();
            makeup.Add("Lipstick", 12);
            makeup.Add("Mascara", 8);
            makeup.Add("Lip gloss", 7);


            Console.WriteLine("+++++++++++++++++++++++");


            Dictionary<string, int> mergingBothDictionaries = products.Concat(makeup).ToDictionary(pair => pair.Key, pair => pair.Value);

            int totalItems = mergingBothDictionaries.Count;
            Console.WriteLine("Total count of products in both dictionaries: " + totalItems);

            Console.WriteLine("+++++++++++++++++++++++");

            var sortedValues = mergingBothDictionaries.Values.OrderBy(v => v);
            foreach (int price in sortedValues)
            {
                Console.WriteLine(price);
            }

        }
    }
}