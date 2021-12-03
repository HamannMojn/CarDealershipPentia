
using System.ComponentModel.DataAnnotations;

namespace CarDealershipApp.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Extras { get; set; }
        public double RecommendedPrice { get; set; }
    }
}