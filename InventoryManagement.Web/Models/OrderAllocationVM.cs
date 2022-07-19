
namespace InventoryManagement.Web.Models
{
    public class OrderAllocationVM
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string ProductName { get; set; }

        public int Quantity_Requested { get; set; }
        public DateTime DateRequested { get; set; }
        public ProductVM Product { get; set; }



    }
}