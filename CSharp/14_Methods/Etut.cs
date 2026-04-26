using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Methods
{
    public class Etut
    {
        public void DiziYazdir(int[] ints)
        {
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
        public void DiziYazdir(string[] strings)
        {
            foreach (string i in strings)
            {
                Console.WriteLine(i);
            }
        }
        public void DiziYazdir(double[] doubles)
        {
            foreach (double i in doubles)
            {
                Console.WriteLine(i);
            }
        }
    }
}
