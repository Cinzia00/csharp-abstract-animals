using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale, IAnimaliCheVolano
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Sto mangiando un insetto");

        }

        public override void Verso()
        {
            Console.WriteLine("Cip cip");

        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }
}

