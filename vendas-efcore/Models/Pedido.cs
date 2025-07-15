using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas_efcore.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public StatusPedido StatusPedido { get; set; }
        public virtual ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido () { }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.Subtotal();
            }
            return total;
        }
        
        public string StatusDoPedido ()
        {
            return StatusPedido.ToString();
        }

        public override string ToString()
        {
            string resultado = $"ID Pedido: {Id} | Cliente: {Cliente.Nome}\n" +
                $"Data: {Date}\n" +
                $"Status do Pedido: {StatusPedido}\n"+
                "\n"+
                $"Itens:\n";

            foreach (var item in Itens)
            {
                resultado += $"Produto: {item.Produto.Nome} | Quantidade: {item.Quantidade} | Subtotal: R${item.Subtotal():F2}\n";
            }

            resultado += $"Total: {CalcularTotal():F2}";
            return resultado;
        }

    }
}
