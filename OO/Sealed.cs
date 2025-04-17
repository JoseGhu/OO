using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class Sealed
    {
        sealed class SemFilho
        {
            public double ValorDaFortana()
            {
                return 1_407_033.65;
            }
        }

        class Avo
        {
            public virtual bool HonrarNomeDaFamilia()
            {
                return true;
            }
        }

        class Pai : Avo
        {
            public sealed override bool HonrarNomeDaFamilia()
            {
                return true;      
            }
        }

        class FilhoRebelde : Pai
        {

        }

        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortana());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeDaFamilia());

        }

    }
}
