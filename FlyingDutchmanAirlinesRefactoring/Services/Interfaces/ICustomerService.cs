namespace FlyingDutchmanAirlinesRefactoring.Services.Interfaces
{
    public interface ICustomerService
    {
        public Task<bool> CreateCustomer(string name);
    }
}
