
using vendas_efcore.Data;
using vendas_efcore.Models;

namespace vendas_efcore.Menus;

internal class MenuMostrarClientes : Menu
{
    public void Executar(DAL<Cliente> clienteDAL)
    {
        base.Executar(clienteDAL);
        ExibirTituloDaOpcao("Clientes Registrados");

        var clientes = clienteDAL.Listar();

        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
            Console.WriteLine("---------------------");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
    }
}
