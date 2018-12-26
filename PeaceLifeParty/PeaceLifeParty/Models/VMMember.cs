using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeaceLifeParty.Models
{
    public class VMMember
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
    }
}