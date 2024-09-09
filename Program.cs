using ComplexNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor real: ");
            double re1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o valor imaginário: ");
            double im1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre com o valor real do segundo: ");
            double re2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o valor imaginário do segundo: ");
            double im2 = Convert.ToDouble(Console.ReadLine());

            NumComplexo z1 = new NumComplexo(re1, im1);
            NumComplexo z2 = new NumComplexo(re2, im2);

            NumComplexo soma = z1.Soma(z2);
            NumComplexo produto = z1.Vezes(z2);

            Console.WriteLine("Forma polar do complexo pela soma:");
            soma.ImprimeFormaPolar();

            Console.WriteLine("Forma polar do complexo pelo produto:");
            produto.ImprimeFormaPolar();

            Console.ReadLine();
        }
    }
    }
