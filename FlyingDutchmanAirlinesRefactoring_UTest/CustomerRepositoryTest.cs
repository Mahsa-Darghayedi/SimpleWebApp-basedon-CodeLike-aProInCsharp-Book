using FlyingDutchmanAirlinesRefactoring.DataAccess.Context;
using FlyingDutchmanAirlinesRefactoring.Repositories.Implementation;
using FlyingDutchmanAirlinesRefactoring.Repositories.Interfaces;
using FlyingDutchmanAirlinesRefactoring.Services.Implementation;
using FlyingDutchmanAirlinesRefactoring.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FlyingDutchmanAirlinesRefactoring_Test
{

    public class CustomerRepositoryTest
    {
        private FlyingDutchManDbContext _context;
        private ICustomerRepository _repository;
        private ICustomerService _service;

        
        public  CustomerRepositoryTest()
        {
            DbContextOptions<FlyingDutchManDbContext> dbContextOptions = new DbContextOptionsBuilder<FlyingDutchManDbContext>().UseInMemoryDatabase("FlyingDutchManDb").Options;
            _context = new FlyingDutchManDbContext(dbContextOptions);
            _repository = new CustomerRepository(_context);

            Assert.NotNull(_repository);

            _service = new CustomerService(_repository);
            Assert.NotNull(_service);


        }


        [Fact]
        public async void CreateCustomer_Success()
        {
            bool result = await _service.CreateCustomer("Mahsa");
            Assert.True(result);

        }

        [Fact]
        public async void CreateCustomer_Falilure_NameIsNull()
        {
            bool result = await _service.CreateCustomer(null);
            Assert.False(result);
        }

        [Fact]
        public async void CreateCustomer_Falilure_NameIsEmtyString()
        {
            bool result = await _service.CreateCustomer(string.Empty);
            Assert.False(result);
        }

        [Theory]
        [InlineData ("M@hsa")]
        [InlineData("Mahsa!")]
        [InlineData("Mahsa#")]
        public async void CreateCustomer_Falilure_NameContainesInvalidChar(string invalidName)
        {
            bool result = await _service.CreateCustomer(invalidName);
            Assert.False(result);
        }
    }
}
