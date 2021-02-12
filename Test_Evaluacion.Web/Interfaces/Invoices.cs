using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Test_Evaluacion.Web.Data;
using Test_Evaluacion.Web.Data.Entities;

namespace Test_Evaluacion.Web.Interfaces
{
    public class Invoices : IInvoice
    {
        private readonly DataContext dataContext;

        public Invoices(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void AddInvoices(Invoice invoice)
        {
            dataContext.Invoices.Add(invoice);
            dataContext.SaveChanges();
        }

        public void DelectInvoice(int id)
        {
            Invoice deleteInvoice = dataContext.Invoices.Find(id);
            dataContext.Invoices.Remove(deleteInvoice);
            dataContext.SaveChanges();
        }

        public List<Invoice> GetInvoices()
        {
            var list = new List<Invoice>();

            foreach (var item in dataContext.Invoices)
            {
                var invoice = new Invoice();
                invoice.Name = item.Name;
                invoice.InvoiceId = item.InvoiceId;
                invoice.Price = item.Price;
                invoice.Quantity = item.Quantity;
                invoice.NameProduct = dataContext.Products.FirstOrDefault(p => p.ProductId == item.ProductId).Name;
                list.Add(invoice);

            }

            return list;
        }

        public Invoice SelectInvoice(int? id)
        {
            return dataContext.Invoices.FirstOrDefault(i => i.InvoiceId == Convert.ToInt32(id));
        }

        public void UpdateInvoices(Invoice invoice)
        {
            dataContext.Entry(invoice).State = EntityState.Modified;
            dataContext.SaveChanges();
        }
    }
}
