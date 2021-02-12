using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluacion.Web.Data.Entities;
using Test_Evaluacion.Web.Models;

namespace Test_Evaluacion.Web.Interfaces
{
    public class Converte : IConverte
    {
        public Invoice ConverteInvoice(InvoicesViewModel model)
        {
            return new Invoice
            {
                DateProduct = model.DateProduct,
                InvoiceId = model.InvoiceId,
                Name = model.Name,
                Price = model.Price,
                Quantity = model.Quantity,
                ProductId = model.ProductId
            };
        }

        public InvoicesViewModel ConverteInvoiceViewModel(Invoice model)
        {
            return new InvoicesViewModel
            {
                DateProduct = model.DateProduct,
                InvoiceId = model.InvoiceId,
                Name = model.Name,
                Price = model.Price,
                Quantity = model.Quantity,
                ProductId = model.ProductId,
            };
        }
    }
}
