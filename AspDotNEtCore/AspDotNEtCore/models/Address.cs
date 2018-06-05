using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNEtCore.models
{
    [Table("Address", Schema="SalesLT")]
    public class Address
    {
        [Column("AddressID")]
        public int AddressID { get; set; }

        [Column("AddressLine1")]
        public string AddressLine1 { get; set; }

        public Address()
        {
        }
    }
}
