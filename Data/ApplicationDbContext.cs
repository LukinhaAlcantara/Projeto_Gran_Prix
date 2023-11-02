using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Gran_Prix.Models;

namespace Projeto_Gran_Prix.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Gran_Prix.Models.CaixaModel>? Caixa { get; set; }
        public DbSet<Gran_Prix.Models.ClientesModel>? Clientes { get; set; }
        public DbSet<Gran_Prix.Models.EstoqueModel>? Estoque { get; set; }
        public DbSet<Gran_Prix.Models.FornecedorModel>? Fornecedor { get; set; }
        public DbSet<Gran_Prix.Models.FuncionarioModel>? Funcionario { get; set; }
    }
}