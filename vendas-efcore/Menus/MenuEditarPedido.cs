
using Microsoft.EntityFrameworkCore;
using vendas_efcore.Data;
using vendas_efcore.Models;

namespace vendas_efcore.Menus;

internal class MenuEditarPedido : Menu
{
    public void Executar(DAL<Pedido> pedidoDAL)
    {
        base.Executar(pedidoDAL);
        ExibirTituloDaOpcao("Editar Pedido:");

        Console.Write("Digite o ID do pedido: ");
        int id = int.Parse(Console.ReadLine()!);
        var pedido = pedidoDAL.Context.Pedidos.Include(p => p.Itens).FirstOrDefault(p => p.Id == id);

        if (pedido == null)
        {
            Console.WriteLine("Pedido não encontrado.");
        }
        else
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Editar Status: ");
            Console.WriteLine("2 - Remover:");
            Console.Write("Escolha Uma Opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Status Atual: {pedido.StatusPedido}\n");
                    Console.WriteLine("Escolha o novo status:");
                    Console.WriteLine("1 - Aguardando Pagamento");
                    Console.WriteLine("2 - Preparando");
                    Console.WriteLine("3 - Enviado");
                    Console.WriteLine("4 - Entregue");
                    Console.Write("Digite o número correspondente: ");
                    int novoStatus = int.Parse(Console.ReadLine()!);

                    pedido.StatusPedido = (StatusPedido)novoStatus;
                    pedidoDAL.Atualizar(pedido);

                    Console.WriteLine("\nStatus do pedido atualizado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("Tem certeza que deseja remover esse pedido? s/n");
                    char confirmar = Console.ReadLine().ToUpper()[0];
                    if (confirmar == 'S')
                    {
                        pedidoDAL.Remover(pedido);
                        Console.WriteLine("\nPedido removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("\nRemoção cancelada.");
                    }
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida!");
                    break;
            }
        }
        Console.WriteLine("Pressione qualquer tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
    }
}
