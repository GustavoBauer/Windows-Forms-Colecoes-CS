using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Lista
    {
        private List<string> lista = new List<string>();

        public void Adicionar(string elemento)
        {
            lista.Add(elemento);
        }

        public void AdicionarEm(string elemento, int pos)
        {
            lista.Insert(pos, elemento);
        }

        public void Remover(string valor)
        {
            lista.Remove(valor);
        }

        public void RemoverEm(int pos)
        {
            lista.RemoveAt(pos);
        }

        public void Ordenar()
        {
            lista.Sort();
        }

        public List<string> getFila()
        {
            return lista;
        }
    }
}
