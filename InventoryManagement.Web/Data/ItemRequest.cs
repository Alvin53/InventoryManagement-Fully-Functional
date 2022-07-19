using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Web.Data
{
    public class ItemRequest : BaseEntity
    {
       

        public Product Product { get; set; }
        public int ProductId { get; set; }
       
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
      
        public bool OrderStatus { get; set; }
        public int Quantity_Requested { get; set; }
        public DateTime DateRequested { get; set; }

    }
}
