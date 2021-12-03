using System.ComponentModel.DataAnnotations;

namespace CarDealershipApp.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        //String to allow for alphanumeric HousNumber i.e. 13A
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        //String to allow for alphanumeric ZipCodes i.e. 90210B
        public string ZipCode { get; set; }
        public string Country { get; set; }

    }
}

