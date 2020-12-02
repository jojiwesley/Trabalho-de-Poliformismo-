using System;

    class Gerente:Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão de Gerente do vale alimentaçao R$"+(salario * 0.12));
        }
    }
