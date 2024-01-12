using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Iroda
    {
        public string kód { get; set; }
        public string kezdet { get; set; }
        public List<int> irodak { get; set; }
        public Iroda(string sor)
        {
            irodak = new List<int>();
            var tmp = sor.Split(" ");
                kód = tmp[0];
            kezdet = tmp[1];
            for (int i = 2; i < tmp.Length; i++)
            {


                irodak.Add(int.Parse(tmp[i]));


            }

        }
        public override string ToString()
        {
            string returns = $"kód: {kód}, kezdet: {kezdet}, irodahaz: ";
            foreach (var j in irodak) returns += j + " ";
            return returns;
        }

    }


}
