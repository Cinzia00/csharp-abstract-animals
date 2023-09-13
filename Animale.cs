using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi() 
        {
            Console.WriteLine("ZzzZzz");
        }
        public abstract void Verso();
        //(mostra a video il verso fatto dall'animale specifico)
        public abstract void CosaMangi();
        //(mostra a video quello che mangia : erba, carne, ...?)
    }
}
