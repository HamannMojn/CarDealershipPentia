using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace CarDealershipApp.Models
{
    public class CarPurchase
    {
        [Key]
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public List<Car> Car { get; set; }
        public DateTime OrderDate { get; set; }
        public Double PricePaid { get; set; }
        public SalesPerson SalesPerson { get; set; }

    }
}
