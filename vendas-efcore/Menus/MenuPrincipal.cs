
using vendas_efcore.Data;
using vendas_efcore.Models;

namespace vendas_efcore.Menus;

internal class MenuPrincipal
{

    private readonly DAL<Cliente> clienteDAL = new(new VendasContext());
    private readonly DAL<Produto> produtoDAL = new(new VendasContext());
    private readonly DAL<Pedido> pedidoDAL = new(new VendasContext());

    public void Exibir()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========== MENU PRINCIPAL ==========");
            Console.WriteLine("1 - Registrar Cliente");
            Console.WriteLine("2 - Registrar Produto");
            Console.WriteLine("3 - Registrar Pedido");
            Console.WriteLine("4 - Mostrar Todos os Clientes");
            Console.WriteLine("5 - Mostrar Pedidos por Cliente");
            Console.WriteLine("6 - Editar ou Remover Pedido");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine()!;
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    new MenuRegistrarCliente().Executar(clienteDAL);
                    break;
                case "2":
                    new MenuRegistrarProduto().Executar(produtoDAL);
                    break;
                case "3":
                    new MenuRegistrarPedido().Executar(clienteDAL);
                    break;
                case "4":
                    new MenuMostrarClientes().Executar(clienteDAL);
                    break;
                case "5":
                    new MenuMostrarPedidosDoCliente().Executar(clienteDAL);
                    break;
                case "6":
                    new MenuEditarPedido().Executar(pedidoDAL);
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    Thread.Sleep(2000);
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
