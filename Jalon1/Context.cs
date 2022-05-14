using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Jalon1.Entities;

namespace Jalon1
{
    public class Context : DbContext
    {
        public Context() : base("name=Test")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Editeur> Editeurs { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Jeu> Jeux { get; set; }
    }
}