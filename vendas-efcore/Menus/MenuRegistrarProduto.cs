
using vendas_efcore.Data;
using vendas_efcore.Models;

namespace vendas_efcore.Menus;

internal class MenuRegistrarProduto : Menu
{
    public void Executar(DAL<Produto> produtoDAL)
    {
        base.Executar(produtoDAL);
        ExibirTituloDaOpcao("Registro de Produto");
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine()!);

        Produto produto = new(nome, preco);
        produtoDAL.Adicionar(produto);

        Console.WriteLine("Produto registrado com sucesso!");
        Console.WriteLine();
        char confirmar;
        do
        {
            Console.WriteLine("Deseja adicionar mais algum produto? s/n");
            confirmar = Console.ReadLine().ToUpper()[0];
            Console.WriteLine();
            if (confirmar == 'S')
            {
                Console.Write("Digite o nome do produto: ");
                nome = Console.ReadLine()!;
                Console.Write("Digite o preço do produto: ");
                preco = double.Parse(Console.ReadLine()!);

                Produto novoProduto = new(nome, preco);
                produtoDAL.Adicionar(novoProduto);
                Console.WriteLine("Produto registrado com sucesso!");
            }
            else
            {
                return;
            }
        } while (confirmar == 'S');

        Thread.Sleep(3000);
        Console.Clear();
    }
}
