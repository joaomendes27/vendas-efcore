using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas_efcore.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PrecoUnitario { get;  set; }

        public Produto() { }

        public Produto (string nome, double precoUnitario)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
        }

        public override string ToString()
        {
            return $"Produto: {Nome}\n" +
                $"Id: {Id}\n" +
                $"Preço Unidade: {PrecoUnitario}";
        }
    }
}
