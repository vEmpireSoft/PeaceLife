using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vEmpireSoft.PPL.Data.DomainModel;


namespace vEmpireSoft.PPL.Data.DBContext
{
   public class PLPDBContext :DbContext
    {
       public PLPDBContext()//DB_A43B6B_PLPDB
           : base("PLPDB")
       {
           //Database.SetInitializer<PLPDBContext>(new CreateDatabaseIfNotExists<PLPDBContext>());

           Database.SetInitializer<PLPDBContext>(new DropCreateDatabaseIfModelChanges<PLPDBContext>());
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
