using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas_efcore.Data
{
    internal class DAL<T> where T : class
    {
        protected readonly VendasContext context;
        public VendasContext Context => context;

        public DAL(VendasContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }

        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }
        public void Atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public void Remover(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }
        public T? RecuperarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }
    }
}

