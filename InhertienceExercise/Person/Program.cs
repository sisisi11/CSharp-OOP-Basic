﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main()
    {

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        try
        {
            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }
}