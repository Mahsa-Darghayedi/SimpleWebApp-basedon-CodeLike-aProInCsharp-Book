using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using FlyingDutchmanAirlinesRefactoring.Repositories.Base;

namespace FlyingDutchmanAirlinesRefactoring.Repositories.Interfaces
{
    public interface ICustomerRepository :IGenericRepository<int, Customer>
    {
    }
}
