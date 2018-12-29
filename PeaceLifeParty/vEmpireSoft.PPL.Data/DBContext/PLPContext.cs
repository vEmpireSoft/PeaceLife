using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vEmpireSoft.PPL.Data.DomainModel;


namespace vEmpireSoft.PPL.Data.DBContext
{
   public class PLPContext :DbContext
    {
       public PLPContext()
           : base("name=PLPDBConnectionString")
       {
           Database.SetInitializer<PLPContext>(new CreateDatabaseIfNotExists<PLPContext>());

           //Database.SetInitializer<PPLContext>(new DropCreateDatabaseIfModelChanges<PPLContext>());
           //Database.SetInitializer<PPLContext>(new DropCreateDatabaseAlways<PPLContext>());
           //Database.SetInitializer<PPLContext>(new PLPDBInitializer());
       }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           //Configure domain classes using modelBuilder here..

       }

       public DbSet<Comment> Comment { get; set; }
       public DbSet<Member> Member { get; set; }
    }
}
