using System.Collections.Generic;
using Test_Evaluacion.Web.Data.Entities;

namespace Test_Evaluacion.Web.Interfaces
{
    public interface IInvoice
    {
        List<Invoice> GetInvoices();
        void AddInvoices(Invoice invoice);
        void UpdateInvoices(Invoice invoice);
        Invoice SelectInvoice(int? id);

        void DelectInvoice(int id);
    }
}
