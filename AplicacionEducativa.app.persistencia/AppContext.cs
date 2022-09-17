using Microsoft.EntityFrameworkCore;
using AplicacionEducativa.app.persistencia.Entidades;
namespace AplicacionEducativa.app.persistencia

{
    public class dbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7ENSJ5DM;Initial Catalog=Prueba;Integrated Security=True");

        }
              

               public DbSet<Alumno> alumno { get; set; }
               public DbSet<Materia> materia { get; set; }




    }
}

