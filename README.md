# 🛒 Sistema de Vendas com Entity Framework Core

Este é um projeto de sistema de vendas criado para fins de estudo e prática com C#, .NET e Entity Framework Core. Com ele, é possível cadastrar clientes, produtos e registrar pedidos com itens e status.

## Funcionalidades

-  Cadastro de clientes
-  Cadastro de produtos
-  Atualização de status do pedido
-  Remoção de pedidos
-  Cálculo automático de total do pedido e subtotais por item
-  Persistência de dados com Entity Framework Core e SQL Server

## Tecnologias Utilizadas

- C# com .NET 6 (ou superior)
- Entity Framework Core
- SQL Server (ou LocalDB)
- Migrations para criação automática do banco de dados
- Console Application (interface de linha de comando)

- ## ✅ Como rodar o projeto localmente

1. Clone este repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repo.git
   ```

2. Restaure os pacotes NuGet:

   ```bash
   dotnet restore
   ```

3. Atualize o banco de dados com a migration existente:

   ```bash
   dotnet ef database update
   ```

4. Execute o projeto:

   ```bash
   dotnet run
   ```

🔔 Certifique-se de que sua máquina tem o **SQL Server** ou **SQL Server LocalDB** instalado.


