using System;
using Microsoft.EntityFrameworkCore;

namespace AspDotNEtCore.models
{
    public class TestDbContext : DbContext
    {
        public virtual DbSet<Address> Addresses { get; set; }
        //public virtual DbSet<Person> People { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }
    }
}
