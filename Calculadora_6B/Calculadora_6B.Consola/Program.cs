using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6B.libreria;

namespace Calculadora_6B.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo misMetdos = new Metodo();
            Console.WriteLine(misMetdos.Saludar());
            Console.ReadKey();
        }

        public float sumar(float valor1, float valor2)
        {
            var resultado = valor1 + valor2;
            return resultado;
        }

        public float restar(float valor1, float valor2)
        {
            var resultado = valor1 - valor2;
            return resultado;
        }

        public float multiplicarr(float valor1, float valor2)
        {
            var resultado = valor1 * valor2;
            return resultado;
        }

        public float dividir(float valor1, float valor2)
        {
            var resultado = valor1 / valor2;
            return resultado;
        }
    }
}
