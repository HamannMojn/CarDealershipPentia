using CarDealershipApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipPentia.Models
{
    public class CustomerForDisplay
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public DateTime Created { get; set; }
        public List<CarPurchase> Purchases { get; set; }
        public List<Car> Cars { get; set; }
        public List<SalesPerson> SalesPersons {get; set;}
    }
}
