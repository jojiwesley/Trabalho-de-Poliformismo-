using System;


        class Imposto 
    {
        //Métodos 
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrão do vale alimentaçao R$"+(salario * 0.1));
        }

        public virtual void ValeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do vale Transporte R$"+(salario * 0.06));
        }
        
    }