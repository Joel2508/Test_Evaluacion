using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluacion.Web.Data.Entities;

namespace Test_Evaluacion.Web.Models
{
    public class InvoicesViewModel:Invoice
    {
        [Display(Name = "Product")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes selecionar un product.")]
        public int Product { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }
    }
}
