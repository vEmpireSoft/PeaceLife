using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vEmpireSoft.PPL.Data.DBContext;
using vEmpireSoft.PPL.Data.DomainModel;
using vEmpireSoft.PPL.Data.Repository.Interface;

namespace vEmpireSoft.PPL.Data.Repository
{
    public class MemberRepository : GeneralRepository<Member>, IMemberRepository
    {
        public MemberRepository(PLPDBContext db)
            : base(db)
        {
        }
    }
}
