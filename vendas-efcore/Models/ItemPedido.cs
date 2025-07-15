using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas_efcore.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public virtual Pedido Pedido { get; set; }
       
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }


        public ItemPedido() { }

        public double Subtotal()
        {
            return Quantidade * PrecoUnitario;
        }
    }
}
