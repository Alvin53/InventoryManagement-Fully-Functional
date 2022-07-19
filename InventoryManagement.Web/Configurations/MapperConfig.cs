using AutoMapper;
using InventoryManagement.Web.Data;
using InventoryManagement.Web.Models;

namespace InventoryManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<OrderAllocation, OrderAllocationVM>().ReverseMap();


        }
    }
}
