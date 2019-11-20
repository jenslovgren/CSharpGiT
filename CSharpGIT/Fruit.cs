using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGIT
{
    public class Fruit
    {
        public Fruit(string name, double weight, double cost)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }

        public string Name { get; set; }
        public double Weight { get; set; }

        public double Cost { get; set; }

    }
}
