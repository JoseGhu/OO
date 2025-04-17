using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    class UsandoOThis
    {
        public class Animal
        {
            public string Nome { get; set; }

            public Animal(string nome)
            {
                nome = nome;
            }
        }

        public class Cachorro : Animal
        {
            public double Altura { get; set; }

            public Cachorro(string nome) : base(nome)
            { 
                Console.WriteLine($"Cachorro {nome} inicializado");
            }

            public Cachorro(string nome, double altura) : this(nome)
            {
                Altura = altura;
            }

            public override string ToString()
            {
                return $"{Nome} tem {Altura}cm de altura!";
            }
        }

        public static void Executar()
        {
            var suzy = new Cachorro("Suzy");
            var meguie = new Cachorro("Meguie", 20.0);

            Console.WriteLine(suzy);
            Console.WriteLine(meguie);
        }
    }
}
