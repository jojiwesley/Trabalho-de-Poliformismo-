using System;
    class Atendente:Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão de Atendente do vale alimentaçao R$"+(salario * 0.15));
        }
    }
