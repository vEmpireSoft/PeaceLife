using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vEmpireSoft.PPL.Data.DomainModel
{
    [Table("MemberDetail")]
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Column(TypeName = "char")]
        [Required]
        [MaxLength(10)]
        [Required]
        public string Title { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Surname { get; set; }
        [MaxLength(50)]
        [Required]
        public string AddressLine1 { get; set; }
        [MaxLength(50)]
        [Required]
        public string AddressLine2 { get; set; }
        [MaxLength(50)]
        [Required]
        public string AddressLine3 { get; set; }
        [MaxLength(50)]
        [Required]
        public string Suburb { get; set; }
        [MaxLength(50)]
        [Required]
        public string State { get; set; }
        [MaxLength(20)]
        [Required]
        public string PostCode { get; set; }
        [MaxLength(20)]
        public string HomePhoneNumber { get; set; }
        [MaxLength(20)]
        public string WorkPhoneNumber { get; set; }
        [MaxLength(20)]
        public string MobileNumber { get; set; }
        [MaxLength(20)]
        public string FaxNumber { get; set; }
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime RegisteredDate { get; set; }
    }
}
