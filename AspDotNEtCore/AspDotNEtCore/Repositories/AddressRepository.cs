using System;
using System.Linq;
using AspDotNEtCore.models;

namespace AspDotNEtCore.Repositories
{
    public class AddressRepository
    {
        private TestDbContext testDbContext;

        public AddressRepository(TestDbContext testDbContext)
        {
            this.testDbContext = testDbContext;
        }

        public Address GetAddress(int id) {
            return testDbContext.Addresses.Where((address) => address.AddressID == id).FirstOrDefault();
        }

        //public void Get() {
        //    testDbContext.People.Join(testDbContext.Addresses, a => a.ID, b => b.AddressLine1, (a, b) => new Person { Address = b });
        //}
    }
}
