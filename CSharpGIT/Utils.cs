using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGIT
{
    
    static class Utils
    {
        static Random rng = new Random();

        public static int RandomNumberGenerator(int a, int b) => rng.Next(a, b + 1);
        
           
        
    }
}
