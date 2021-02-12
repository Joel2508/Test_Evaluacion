using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluacion.Web.Data.Entities;
using Test_Evaluacion.Web.Interfaces;
using Test_Evaluacion.Web.Models;

namespace Test_Evaluacion.Web.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IInvoice invoice;
        private readonly ICombo combo;
        private readonly IConverte converte;

        public InvoicesController(IInvoice invoice, ICombo combo, IConverte converte)
        {
            this.invoice = invoice;
            this.combo = combo;
            this.converte = converte;
        }

        public ActionResult Index()
        {
            var list = invoice.GetInvoices();
            return View(list);
        }

        public ActionResult AddInvoice()
        {
            var invoiceCombo = new InvoicesViewModel();
            invoiceCombo.Products = combo.SelectListItemsProduct();
            return View(invoiceCombo);
        }

        [HttpPost]
        public ActionResult AddInvoice(InvoicesViewModel model)
        {
            try
            {
                var invoiceConverte = converte.ConverteInvoice(model);
                invoice.AddInvoices(invoiceConverte);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        public ActionResult EditInvoice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var invoices = invoice.SelectInvoice(id);
            var converteInvoiceViewModel = converte.ConverteInvoiceViewModel(invoices);
            converteInvoiceViewModel.Products = combo.SelectListItemsProduct();
            return View(converteInvoiceViewModel);
        }

        [HttpPost]
        public ActionResult EditInvoice(InvoicesViewModel model)
        {
            if (model == null)
            {
                return NotFound();
            }
            var editInvoice = converte.ConverteInvoice(model);
            invoice.UpdateInvoices(editInvoice);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult DeleteInvoice(int id)
        {
            invoice.DelectInvoice(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
