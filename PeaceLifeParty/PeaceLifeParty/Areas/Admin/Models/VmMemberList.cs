using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vEmpireSoft.PPL.Service;
using vEmpireSoft.PPL.Service.Services.MemberRegistration;

namespace PeaceLifeParty.Areas.Admin.Models
{
    public class VmMemberList
    {
        public MemberRegService _service;
        public IList<MemberDto> memberList { get; set; }
        public VmMemberList()
        {
            if (memberList == null)
                memberList = new List<MemberDto>();
            _service = new MemberRegService();
        }

        public IList<MemberDto> MemberList()
        {
             memberList=_service.GetAllMembers();
             return memberList;
        }
    }
}