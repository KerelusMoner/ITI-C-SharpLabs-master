using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            int[] game = new int[5] { 1, 2, 3, 4, 5 };
            int s = 0;
            
            foreach ( int i in game) 
            {
                Console.WriteLine(i);
                s=s+i;
                
            }
        }
    }
}
