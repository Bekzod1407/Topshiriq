using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topshiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n ni kiriting");
            n=Int32.Parse(Console.ReadLine());
            int s = 0;
            for ( int i=1; i <= n; i++ )
            {
                s = s + i;
            }

            Console.WriteLine("n ta sonning yigindisi ={0}",s);

        }
    }
}
