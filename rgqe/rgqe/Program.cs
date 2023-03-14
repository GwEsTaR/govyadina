using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace rgqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            string[] mass = {"HAT", "HAB4T.HMG.QA","LOM13.GXT"};
            var xp = mass.SelectMany(x => x.Split('.')).Where(x => x.Length == k).OrderBy(x => x);
            foreach (var i in xp)
            Console.Write($"{i} ");
            Console.ReadKey();
        }
    }
}
