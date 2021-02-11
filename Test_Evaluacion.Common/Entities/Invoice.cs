using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test_Evaluacion.Common.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]        
        public string Name { get; set; }
        [Required]        
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
