using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext (string[] args)
        {
           //Usado para criar as migrações
           var connectionString = @"Server=MAT065\SQLEXPRESS;Database=dbAPI;Integrated Security=SSPI;";
           var optionBuilder = new DbContextOptionsBuilder<MyContext> ();
           optionBuilder.UseMySql (connectionString);
           return new MyContext (optionBuilder.Options);
        }
    }
}
   