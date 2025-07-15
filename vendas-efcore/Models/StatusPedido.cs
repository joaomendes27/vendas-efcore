using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas_efcore.Models
{
    public enum StatusPedido
    {
        AguardandoPagamento = 1,
        Preparando = 2,
        Enviado = 3,
        Entregue = 4
    }
}
