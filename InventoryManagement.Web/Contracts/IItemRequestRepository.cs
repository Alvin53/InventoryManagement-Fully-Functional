using InventoryManagement.Web.Data;
using InventoryManagement.Web.Models;

namespace InventoryManagement.Web.Contracts
{
    public interface IItemRequestRepository : IGenericRepository<ItemRequest>
    {
        Task CreateItemRequest(ItemRequestCreateVM model);
        Task <EmployeeItemRequestViewVM>GetMyItemRequestDetails();
        Task <List<ItemRequest>>GetAllAsync(string employeeId);
    }
}
