using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale, IAnimaliCheNuotano
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Sto mangiando un pesce");

        }

        public override void Verso()
        {
            Console.WriteLine("Fii fiii");

        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
    }
}
