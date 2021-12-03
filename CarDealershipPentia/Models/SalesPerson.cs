using System.ComponentModel.DataAnnotations;

namespace CarDealershipApp.Models
{
    public class SalesPerson
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public Address Address { get; set; }
        public double Salary { get; set; }
    }
}