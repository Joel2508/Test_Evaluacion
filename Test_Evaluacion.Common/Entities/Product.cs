using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test_Evaluacion.Common.Entities
{
   public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
    }
}
