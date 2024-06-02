using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
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
        public int somar(int n1, int n2)
        {
            int res = n1 + n2;

            inserirResultadoNaLista($"Resultado da operação {n1}+{n2}: {res}");

            return res;
        }
        public int subtrair(int n1, int n2)
        {
            int res = n1 - n2;

            inserirResultadoNaLista($"Resultado da operação {n1}-{n2}: {res}");

            return res;
        }
        public int multiplicar(int n1, int n2)
        {
            int res = n1 * n2;

            inserirResultadoNaLista($"Resultado da operação {n1}*{n2}: {res}");

            return res;
        }
        public int dividir(int n1, int n2)
        {
            int res = n1 / n2;

            inserirResultadoNaLista($"Resultado da operação {n1}/{n2}: {res}");

            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

        private void inserirResultadoNaLista(string res)
        {
            listaHistorico.Insert(0, res + " Data: " + data);
        }
    }
}
