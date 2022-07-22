using AutoMapper;
using InventoryManagement.Web.Contracts;
using InventoryManagement.Web.Data;
using InventoryManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Web.Repositories
{
    public class ItemRequestRepository : GenericRepository<ItemRequest>, IItemRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IOrderAllocationRepository orderAllocationRepository;
        private readonly UserManager<Employee> userManager;

        public ItemRequestRepository(ApplicationDbContext context, 
            IMapper mapper, 
            IHttpContextAccessor httpContextAccessor,
            IOrderAllocationRepository orderAllocationRepository,
            UserManager<Employee> userManager ) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.orderAllocationRepository = orderAllocationRepository;
            this.userManager = userManager;
        }

        public async Task CreateItemRequest(ItemRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var itemRequest = mapper.Map<ItemRequest>(model);
            itemRequest.DateRequested = DateTime.Now;
            itemRequest.RequestingEmployeeId = user.Id;
            await AddAsync(itemRequest);

        }

        public async Task<List<ItemRequest>> GetAllAsync(string employeeId)
        {
            return await context.ItemRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<EmployeeItemRequestViewVM> GetMyItemRequestDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var allocations = (await orderAllocationRepository.GetEmployeeAllocations(user.Id)).OrderAllocations;
            var requests = mapper.Map<List<ItemRequestVM>> (await GetAllAsync(user.Id));

            var model = new EmployeeItemRequestViewVM(allocations, requests);

            return model;
        }
    }
}
