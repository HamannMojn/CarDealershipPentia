using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarDealershipApp.Data;
using CarDealershipApp.Models;
using CarDealershipPentia.Models;

namespace CarDealershipPentia.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DataContext _context;

        public CustomersController(DataContext context)
        {
            _context = context;
        }

        // GET: Customers
        public IActionResult Index(string _searchString, string _searchByStreet)
        {
            var customers = _context.Customers
                .Include(x => x.Address)
                .Include(x => x.Purchases)
                    .ThenInclude(x => x.Car)
                .Include(x => x.Purchases)
                    .ThenInclude(x => x.SalesPerson).ToList();

            

            if (!String.IsNullOrEmpty(_searchString))
            {
                customers = customers.Where(x => x.Name.Contains(_searchString) || x.Surname.Contains(_searchString)).ToList();
            }

            if (!String.IsNullOrEmpty(_searchByStreet))
            {
                customers = customers.Where(x => x.Address != null).ToList();
                customers = customers.Where(x => x.Address.Street.Contains(_searchByStreet)).ToList();
            }


            return View(customers.ToList());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _context.Customers.Include(x => x.Purchases).ThenInclude(x => x.Car)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer.Purchases);
        }
    }
}
