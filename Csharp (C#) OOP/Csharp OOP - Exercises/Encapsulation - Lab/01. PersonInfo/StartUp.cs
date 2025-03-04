﻿
namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var items = Console.ReadLine().Split();
                var name = items[0];
                var lastName = items[1];
                var age = int.Parse(items[2]);
                var person = new Person(name, lastName, age);
                persons.Add(person);
            }
            persons.OrderBy(x => x.FirstName)
                .ThenBy(x => x.Age)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
