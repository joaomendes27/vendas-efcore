
using vendas_efcore.Data;
using vendas_efcore.Models;

namespace vendas_efcore.Menus;

internal class MenuMostrarPedidosDoCliente : Menu
{
    public void Executar(DAL<Cliente> clienteDAL)
    {
        base.Executar(clienteDAL);
        ExibirTituloDaOpcao("Pedidos de um Cliente");

        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine()!;
        Console.WriteLine();
        var cliente = clienteDAL.RecuperarPor(c => c.Nome == nomeCliente);

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
        }
        else
        {
            foreach (var pedido in cliente.Pedidos)
            {
                Console.WriteLine(pedido);
                Console.WriteLine("---------------");
            }
        }

        Console.WriteLine("Pressione qualquer tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
    }
}
