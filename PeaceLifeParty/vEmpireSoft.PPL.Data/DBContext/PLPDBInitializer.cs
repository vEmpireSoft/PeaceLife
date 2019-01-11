using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vEmpireSoft.PPL.Data.DBContext
{
    public class PLPDBInitializer : CreateDatabaseIfNotExists<PLPDBContext>
    {
        protected override void Seed(PLPDBContext context)
        {

            base.Seed(context);
        }
    }
}
