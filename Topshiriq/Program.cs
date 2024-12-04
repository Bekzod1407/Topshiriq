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
            Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
            int son = int.Parse(Console.ReadLine());

            string yangison = "";
            while (son > 0)
            {
                yangison = (son % 2) + yangison;
                son /= 2;
            }

            Console.WriteLine($"2-lik sanoq sistemasidagi natija: {yangison}");
        
    }
    }
}
