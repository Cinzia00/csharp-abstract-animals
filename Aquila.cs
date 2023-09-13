using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale, IAnimaliCheVolano
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Sto mangiando la carne");

        }

        public override void Verso()
        {
            Console.WriteLine("Cruoa cruoa");

        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }
}
