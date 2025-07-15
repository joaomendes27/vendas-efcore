using vendas_efcore.Data;
using vendas_efcore.Models;
using Microsoft.EntityFrameworkCore;

namespace vendas_efcore.Menus;

internal class MenuRegistrarPedido : Menu
{
    public  void Executar(DAL<Cliente> clienteDAL)
    {
        base.Executar(clienteDAL);
        ExibirTituloDaOpcao("Registro de Pedido");

        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine()!;
        var clienteRecuperado = clienteDAL.RecuperarPor(c => c.Nome == nomeCliente);

        if (clienteRecuperado is not null)
        {
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine()!;
            var produtoDAL = new DAL<Produto>(clienteDAL.Context);
            var produtoRecuperado = produtoDAL.RecuperarPor(p => p.Nome == nomeProduto);

            if (produtoRecuperado is not null)
            {
                Console.Write("Digite a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Escolha o status do pedido:");
                Console.WriteLine("1 - Aguardando Pagamento");
                Console.WriteLine("2 - Preparando");
                Console.WriteLine("3 - Enviado");
                Console.WriteLine("4 - Entregue");
                Console.Write("Digite o número correspondente: ");
                StatusPedido status = (StatusPedido)int.Parse(Console.ReadLine()!);

                var pedido = new Pedido { StatusPedido = status };
                var item = new ItemPedido
                {
                    Produto = produtoRecuperado,
                    Quantidade = quantidade,
                    PrecoUnitario = produtoRecuperado.PrecoUnitario 
                };

                pedido.Itens.Add(item);
                clienteRecuperado.Pedidos.Add(pedido);

                clienteDAL.Atualizar(clienteRecuperado);

                Console.WriteLine($"\nPedido registrado com sucesso para {clienteRecuperado.Nome}!");
            }
            else
            {
                Console.WriteLine($"\nProduto {nomeProduto} não encontrado!");
            }
        }
        else
        {
            Console.WriteLine($"\nCliente {nomeCliente} não encontrado!");
        }

        Thread.Sleep(3000);
        Console.Clear();
    }
}
