using Microsoft.EntityFrameworkCore;

namespace ApiAluno.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        }




        public DbSet<Models.Aluno> Alunos { get; set; }
    }
}
