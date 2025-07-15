using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas_efcore.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get;  set; }
        public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Cliente() { }

        public Cliente (string nome, string cpf, Pedido pedidos)
        {
            Nome = nome;
            Cpf = cpf;
           
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"Cpf: {Cpf}\n" +
                $"Pedidos Registrados: {Pedidos.Count()}";
        }
    }
}
