using KnowledgeCheck2;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bottles of wine do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());



            var recordList = new List<Wine>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new Wine();

                Console.WriteLine("Enter your the wine type name: e.g Sweet or Dry");
                entry.TypeName = Console.ReadLine();

                Console.WriteLine("Enter the wine flavor e.g Red or White: ");
                entry.Flavor = Console.ReadLine();

                recordList.Add(new Wine() { TypeName = entry.TypeName, Flavor = entry.Flavor });
            }



            // Print out the list of records using Console.WriteLine()
            foreach (var entry in recordList)
                Console.WriteLine("\nWine: " + entry.TypeName + "\nType: " + entry.Flavor + "\n");

        }
    }
}