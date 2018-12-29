using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vEmpireSoft.PPL.Data.DBContext
{
    public class PLPDBInitializer : CreateDatabaseIfNotExists<PLPContext>
    {
        protected override void Seed(PLPContext context)
        {

            base.Seed(context);
        }
    }
}
