using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Test_Evaluacion.Web.Data.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = false)]
        [Display(Name="Date Product")]
        public DateTime DateProduct { get; set; }


        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Product")]
        public int ProductId { get; set; }

        public InvoicesProducts InvoicesProducts { get; set; }

        [NotMapped]
        [Display(Name = "Product")]
        public string NameProduct { get; set; }


    }
}
