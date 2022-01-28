using System;
using Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities;

namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 99,"knight");
            Ninja wedge = new Ninja("Wedje", 100, "Ninja");
            Wizard jenica = new Wizard("Jenica", 23, "White Wizard");
            Wizard topapa = new Wizard("Topapa", 44, "Black Wizard", true);

            Console.WriteLine(arus.Atack());
            Console.WriteLine(wedge.Atack());
            Console.WriteLine(jenica.Atack());
            Console.WriteLine(topapa.Atack(true));
        }
    }
}
