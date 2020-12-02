using System;

namespace repos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar Estagiario
            Imposto objE = new Estagiario();
            objE.valeAlimentacao(1000);
            objE.ValeTransporte(500);
            Console.WriteLine("-----------"); 
            //Instanciar Gerente 
            Imposto objG = new Gerente(); 
            objG.valeAlimentacao(10000);
            objG.ValeTransporte(5000);
            Console.WriteLine("-----------");
            //Instanciar Atendente 
            Imposto objA = new Atendente();
            objA.valeAlimentacao(2000);
            objA.ValeTransporte(1000);
            Console.WriteLine("-----------");

        }
    }
}

