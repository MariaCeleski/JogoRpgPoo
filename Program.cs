using System;
using JogoRpgPoo.src.Entities;

namespace JogoRpgPoo
{

    class Program
    {
        static void Main(string[] args)

        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());

        }
    }

}