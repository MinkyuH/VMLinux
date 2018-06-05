using System;
namespace AspDotNEtCore.models
{
    public class Person
    {
        public long ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double PayRate { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public Address Address { get; set; }
    }
}
