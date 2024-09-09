using System;

namespace ComplexNumbers
{
    public class NumComplexo
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public NumComplexo()
        {
            Re = 0;
            Im = 0;
        }

        public NumComplexo(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public NumComplexo Soma(NumComplexo outro)
        {
            return new NumComplexo(Re + outro.Re, Im + outro.Im);
        }

        public NumComplexo Vezes(NumComplexo outro)
        {
            return new NumComplexo(Re * outro.Re - Im * outro.Im, Re * outro.Im + Im * outro.Re);
        }

        public double Modulo()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public double Argumento()
        {
            return Math.Atan2(Im, Re);
        }

        public void ImprimeFormaPolar()
        {
            double modulo = Modulo();
            double argumento = Argumento();
            Console.WriteLine($"({modulo} * (cos({argumento}) + i * sin({argumento})))");
        }
    }
}