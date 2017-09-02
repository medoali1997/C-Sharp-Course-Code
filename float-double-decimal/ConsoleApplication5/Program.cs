using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            float flVar = 1F / 3;
            double dlVar = 1F / 3;
            decimal dcVar = 1 / 33;

            Console.WriteLine("float value ={0} \ndouble value = {1}  \ndecimal value = {2}", flVar, dlVar, dcVar);

            Console.ReadKey();
        }
    }
}
