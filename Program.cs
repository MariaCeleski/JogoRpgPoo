using System;
using JogoRpgPoo.src.Entities;

namespace JogoRpgPoo
{

    class Program
    {
        static void Main(string[] args)

        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Wedge ninja = new Wedge("Wedge", 42, "Ninja");
            WizardBlack wizardBlack = new WizardBlack("Tepipa", 42, "Black Wizard");



            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wizardBlack.Attack(7));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(ninja.Attack(1));

        }
    }

}