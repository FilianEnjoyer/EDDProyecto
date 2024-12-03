using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    public class Fibonacci
    {
        //Metodo RECURSIVO para calcular Fibonacci
        public int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibo(n - 1) + Fibo(n - 2); // Llamadas recursivas 
        }
        public string ObtenerFibonacci(int n)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i <= n - 1; i++)
            {
                resultado.Append(Fibo(i) + " ");
            }

            return resultado.ToString();
        }
    }
}
