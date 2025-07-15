using Microsoft.EntityFrameworkCore;
using vendas_efcore.Models;

namespace vendas_efcore.Data
{
    internal class VendasContext : DbContext
    {
        public string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }
    }
}
