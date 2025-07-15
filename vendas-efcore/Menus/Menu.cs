using vendas_efcore.Data;

namespace vendas_efcore.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            Console.Clear();
            string asteriscos = new string('*', titulo.Length);
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public void Executar<T>(DAL<T> dal) where T : class
        {
            //
        }
    }
}
