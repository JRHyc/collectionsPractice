using System;
using System.Collections.Generic;


namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Three basic arrays

            // 1.)
            // int[] newArray = {0,1,2,3,4,5,6,7,8,9};
            // Console.WriteLine(newArray[0]);

            // 2.)
            // string[] names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            // foreach (string name in names)
            // {
            //     Console.WriteLine("The name is {0}", name);
            // }

            // 3.)
            // string[] alternates = new string[10];
            // for (int i = 0; i < 10; i++)
            // {
            //     if(i % 2 == 0)
            //     {
            //         alternates[i] = "True";
            //     }
            //     else
            //     {
            //         alternates[i] = "False";
            //     }
            // }    
            // foreach (string alternate in alternates)
            // {
            //     Console.WriteLine(alternate);
            // }
            
            // Multiplication Table
            // int [,] multiTable = new int[10,10];     
            // {
            //     for (int i = 0; i < 10; i++)         
            //     {
            //         for (int j = 0; j < 10; j++)     
            //         {
            //             multiTable[i,j] = (i + 1) * (j + 1);
            //             Console.Write(multiTable[i,j] + "\t");
            //         }
            //         Console.WriteLine();
            //     }
            // }

            // List of Flavors
            List<string> iceCream = new List<string>();

            iceCream.Add("Vanilla");
            iceCream.Add("Strawberry");
            iceCream.Add("Nutella");
            iceCream.Add("Mint");
            iceCream.Add("Coffee");

            Console.WriteLine("We currently have {0} types of ice cream!", iceCream.Count);
            Console.WriteLine("Our third most popular flavor is " + iceCream[3] + "!");
            iceCream.RemoveAt(3);
            Console.WriteLine("We currently have {0} types of ice cream!", iceCream.Count);
            Console.WriteLine("Our third most popular flavor is " + iceCream[3] + "!");

            // Info Dictionary
            Dictionary<string,string> userInfo = new Dictionary<string,string>();
            userInfo.Add("Tim", null);
            userInfo.Add("Martin", null);
            userInfo.Add("Nikki", null);
            userInfo.Add("Sara", null);
            userInfo["Tim"] = "Vanilla";
            userInfo["Martin"] = "Mint";
            userInfo["Nikki"] = "Nutella";
            userInfo["Sara"] = "Coffee";
            foreach (var entry in userInfo)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }




        }
    }
}
