using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Conjunto
    {
        private HashSet<string> conjunto = new HashSet<string>();

        public void Adicionar(string elemento)
        {
            conjunto.Add(elemento);
        }

        public bool Contem(Conjunto conjunto2)
        {
            return conjunto.IsSupersetOf(conjunto2.GetConjunto());
        }

        public bool EstaContido(Conjunto conjunto2)
        {
            return conjunto.IsSubsetOf(conjunto2.GetConjunto());
        }

        public void Intersectar(Conjunto conjunto2)
        {
            conjunto.IntersectWith(conjunto2.GetConjunto());
        }

        public void Unir(Conjunto conjunto2)
        {
            conjunto.UnionWith(conjunto2.GetConjunto());
        }

        public void Subtrair(Conjunto conjunto2)
        {
            conjunto.ExceptWith(conjunto2.GetConjunto());
        }

        public HashSet<string> GetConjunto()
        {
            return conjunto;
        }

    }
}
