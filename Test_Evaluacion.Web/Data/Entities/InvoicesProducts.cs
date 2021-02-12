using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Evaluacion.Web.Data.Entities
{
    public class InvoicesProducts
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
