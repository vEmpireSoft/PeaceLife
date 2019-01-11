using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vEmpireSoft.PPL.Data.DBContext;
using vEmpireSoft.PPL.Data.Repository.Interface;

namespace vEmpireSoft.PPL.Data.Repository
{
    public class Context : IContext
    {
        protected PLPDBContext db = null;
        public Context(PLPDBContext context)
        {
            db = context;
            MemberRepo = new MemberRepository(context);
        }

        private bool disposed = false;

       public IMemberRepository MemberRepo { get; private set; }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public virtual void Complete()
        {
            try
            {

                db.SaveChanges();

            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                List<string> errorMessages = new List<string>();
                foreach (DbEntityValidationResult validationResult in ex.EntityValidationErrors)
                {
                    string entityName = validationResult.Entry.Entity.GetType().Name;
                    foreach (DbValidationError error in validationResult.ValidationErrors)
                    {
                        errorMessages.Add(entityName + "." + error.PropertyName + ": " + error.ErrorMessage);
                    }
                }

            }
        }

    }
}
