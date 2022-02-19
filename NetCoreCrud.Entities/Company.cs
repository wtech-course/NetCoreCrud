using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetCoreCrud.Entities
{
    public class Company
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Company_Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Company_Test { get; set; }
        [StringLength(50)]
        [Required]
        public string Company_Address { get; set; }
    }
}


