using InventoryManagement.Web.Data;
using InventoryManagement.Web.Models;

namespace InventoryManagement.Web.Contracts
{
    public interface IOrderAllocationRepository: IGenericRepository<OrderAllocation>
    {
        Task OrderAllocation(int productId); //COME BACK AND CHANGE productId to diffenrt parameter if failed
        Task<bool> AllocationExists(string employeeId, int productId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<OrderAllocationEditVM> GetEmployeeAllocation(int id);
    }
}
