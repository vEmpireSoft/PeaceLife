using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vEmpireSoft.PPL.Service;
using vEmpireSoft.PPL.Service.Services.MemberRegistration;

namespace PeaceLifeParty.Models
{
    public class VMMember
    {
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Email { get; set; }
        public string FaxNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string HomePhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"\s*(?:\+?(\d{1,3}))?([-. (]*(\d{3})[-. )]*)?((\d{3})[-. ]*(\d{2,4})(?:[-.x ]*(\d+))?)\s*", ErrorMessage = "Invalid Phone Number")]
        public string MobileNumber { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Suburb { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Title { get; set; }

        public MemberDto Entity;
        public MemberRegService _service;

        public VMMember()
        {
            if (Entity == null)
                Entity = new MemberDto();
            _service = new MemberRegService();
        }

        public bool SaveEntity(VMMember obj)
        {
            Entity.FirstName = obj.FirstName;
            Entity.Surname = obj.Surname;
            Entity.Email = obj.Email;
            Entity.AddressLine1 = obj.AddressLine1;
            Entity.AddressLine2 = obj.AddressLine2;
            Entity.AddressLine3 = obj.AddressLine3;
            Entity.MobileNumber = obj.MobileNumber;
            Entity.HomePhoneNumber = obj.HomePhoneNumber;
            Entity.Suburb = obj.Suburb;
            Entity.State = obj.State;
            Entity.PostCode = obj.PostCode;
            Entity.Title = obj.Title;

            return _service.Add(Entity);
        }

        public bool SaveEntity(MemberDto obj)
        {
            return _service.Add(obj);
        }
    }
}