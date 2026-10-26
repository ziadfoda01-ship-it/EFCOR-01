using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCOR_01
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        public decimal Price { get; set; }
        public string EmailAddress { get; set; }
    }
}
