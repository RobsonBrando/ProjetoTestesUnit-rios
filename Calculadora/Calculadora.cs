using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProject
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int x, int y)
        {
            int resultado = x + y;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }
        public int Subtrair(int x, int y)
        {
            int resultado = x - y;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }
        public int Multiplicar(int x, int y)
        {
            int resultado = x * y;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }
        public int Dividir(int x, int y)
        {
            int resultado = x / y;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}
