using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluacion.Web.Data;

namespace Test_Evaluacion.Web.Interfaces
{
    public class Combo : ICombo
    {
        private readonly DataContext dataContext;

        public Combo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> SelectListItemsProduct()
        {
            var list = dataContext.Products.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.ProductId.ToString()
            }).OrderBy(l => l.Text).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Select product...]",
                Value = "0"
            });
            return list;
        }
    }
}
