using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluacion.Web.Data.Entities;
using Test_Evaluacion.Web.Models;

namespace Test_Evaluacion.Web.Interfaces
{
    public interface IConverte
    {
        Invoice ConverteInvoice(InvoicesViewModel model);
        InvoicesViewModel ConverteInvoiceViewModel(Invoice model);
    }
}
