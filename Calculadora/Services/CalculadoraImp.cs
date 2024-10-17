using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> ListaHistorico;
        private string data;

        public CalculadoraImp(string data)
            {
               ListaHistorico = new List<string>();
               this.data = data;
            }
        
        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;

            ListaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);

            return resultado;
        }

         public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;

           ListaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);

            return resultado;
        }

         public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;

            ListaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);

            return resultado;
        }

         public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;

           ListaHistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);

            return resultado;
        }

        public List<string> Historico()
        {

            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);

            return ListaHistorico;
        }

    }
}