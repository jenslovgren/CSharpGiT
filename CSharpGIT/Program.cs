using System;
using System.Collections.Generic;

namespace CSharpGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new List<Fruit>();

            fruits.Add(new Fruit("Banana", 0.1, 3));
            fruits.Add(new Fruit("Apple", 0.05, 2));
            fruits.Add(new Fruit("Pineapple", 1, 8));
            fruits.Add(new Fruit("Lemon", 0.15, 1));


        }
    }
}
