
using vendas_efcore.Data;
using vendas_efcore.Models;

namespace vendas_efcore.Menus;

internal class MenuRegistrarCliente : Menu
{
    public void Executar(DAL<Cliente> clienteDAL)
    {
        base.Executar(clienteDAL);
        ExibirTituloDaOpcao("Registro de Cliente");
        Console.Write("Digite o nome do cliente: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite o CPF do cliente: (11 digitos, sem pontuação!) ");
        string cpf = (Console.ReadLine()!);

        Cliente cliente = new(nome, cpf, null!);
        clienteDAL.Adicionar(cliente);

        Console.WriteLine("Cliente registrado com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
