using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Dicionario
    {
        private Dictionary<string, double> dicionario = new Dictionary<string, double>();

        public void Adicionar(string chave, double valor)
        {
            dicionario.Add(chave, valor);
        }

        public void Alterar(string chave, double valor)
        {
            dicionario[chave] = valor;
        }

        public void Remover(string chave)
        {
            dicionario.Remove(chave);
        }

        public bool VerificaChave(string chave)
        {
            return dicionario.ContainsKey(chave);
        }

        public bool VerificaValor(double valor)
        {
            return dicionario.ContainsValue(valor);
        }

        public Dictionary<string, double> getDicionario()
        {
            return dicionario;
        }
    }
}
