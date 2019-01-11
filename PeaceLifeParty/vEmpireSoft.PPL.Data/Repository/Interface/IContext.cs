using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vEmpireSoft.PPL.Data.Repository.Interface
{
    public interface IContext : IDisposable
    {
        IMemberRepository MemberRepo { get; }
        void Complete();
    }
}
