using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers;

public class HomeController : Controller
{
    private static List<Customer> customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "田中" },
        new Customer { Id = 2, Name = "佐藤" }
    };

    public IActionResult Index()
    {
        return View(customers);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string name)
    {
        var newCustomer = new Customer
        {
            Id = customers.Count + 1,
            Name = name
        };

        customers.Add(newCustomer);

        return RedirectToAction("Index");
    }
}