using FlyingDutchmanAirlinesRefactoring.DataAccess.Context;
using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using FlyingDutchmanAirlinesRefactoring.Repositories.Implementation;
using FlyingDutchmanAirlinesRefactoring.Repositories.Interfaces;
using FlyingDutchmanAirlinesRefactoring.Services.Interfaces;

namespace FlyingDutchmanAirlinesRefactoring.Services.Implementation
{
    public class CustomerService :  ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;   
        }

        private bool IsInvalidCustomerName(string name)
        {
            return string.IsNullOrEmpty(name) || name.ToCharArray().Any(c => !(char.IsLetterOrDigit(c)));
        }

        public async Task<bool> CreateCustomer(string name)
        {
           if(IsInvalidCustomerName(name))
                return await Task.FromResult(false);  


           Customer customer = new(name);  

           return await Task.FromResult(true);
            
        }
    }
}
