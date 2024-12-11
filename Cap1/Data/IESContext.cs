using Cap1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace Cap1.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {
        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
    }
}