using CustomerDatalayer.BusinessEntities;
using CustomerDatalayer.Repositories;

namespace CustomerDatalayer.Integration.Tests
{
    public class AddressRepositoryTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAddressRepository()
        {
            var repository = new AddressRepository();
            Assert.NotNull(repository);
        }

        [Fact]
        public void ShouldBeAbleToCreateAddress()
        {
            var repository = new AddressRepository();
            var address = new Addresses()
            {
                CustomerId = repository.GetCustomerID(),
                AddressLine1 = "Mulholland Drive",
                AddressLine2 = "13/1",
                AddressType = "Shipping",
                City = "Los Angeles",
                PostalCode = "90012",
                AddrState = "California",
                Country = "USA"
            };
            repository.Create(address); 
        }
    }
}