using System.ComponentModel.DataAnnotations;

namespace Test_Evaluacion.Web.Data.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }

        public InvoicesProducts InvoicesProducts { get; set; }
    }
}
