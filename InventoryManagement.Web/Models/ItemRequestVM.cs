using InventoryManagement.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Web.Models
{
    public class ItemRequestVM
    {
        public int Id { get; set; }
        [ForeignKey("ProductId")]
        public ProductVM Product { get; set; }
        public int ProductQuantity { get; set; }
        public int Quantity_Requested { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequstComments { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
