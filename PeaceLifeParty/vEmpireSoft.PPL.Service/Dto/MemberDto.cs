using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace vEmpireSoft.PPL.Service
{
    public class MemberDto
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required]
        public string Suburb { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
}
