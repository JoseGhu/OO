using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.OO.Abstract.Celular;

namespace CursoCSharp.OO
{
    class Abstract
    {

        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Trim, Triim, Trim...";
            }

            public class Samsung : Celular
            {
                public override string Assistente()
                {
                    return "Olá! Meu nome é Bixby!";
                }
            }

            public class Iphone : Celular
            {
                public override string Assistente()
                {
                    return "Olá! Meu nome é Siri!";
                }
            }
        }

        public static void Executar()
        {
            var Celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach(var celular in Celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
