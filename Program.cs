using System;
using Orientacao_objetos_usando_um_jogo_RPG.src.Entities;

namespace Orientacao_objetos_usando_um_jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth arus = new Knigth("Arus", 23, "knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());

            

     
        }
    }
}
