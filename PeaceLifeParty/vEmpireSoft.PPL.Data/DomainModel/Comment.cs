using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace vEmpireSoft.PPL.Data.DomainModel
{
    [Table("Comment")]
   public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(8000)]
        [Required]
        public string Comments { get; set; }
    }
}
