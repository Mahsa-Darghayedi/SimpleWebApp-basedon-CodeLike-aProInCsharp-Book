using FlyingDutchmanAirlinesRefactoring.DataAccess.Context;
using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using FlyingDutchmanAirlinesRefactoring.Repositories.Base;
using FlyingDutchmanAirlinesRefactoring.Repositories.Interfaces;

namespace FlyingDutchmanAirlinesRefactoring.Repositories.Implementation
{
    public class CustomerRepository : GenericRepository<int, Customer>, ICustomerRepository
    {
        public CustomerRepository(FlyingDutchManDbContext contex) : base(contex)
        {
        }
    }
}
