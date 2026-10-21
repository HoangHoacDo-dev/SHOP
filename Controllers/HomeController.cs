using Microsoft.AspNetCore.Mvc;
using SHOP.Models;

namespace SHOP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Category()
    {
        var categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Điện thoại",
                Description = "Điện thoại di động"
            },
            new Category
            {
                Id = 2,
                Name = "Laptop",
                Description = "Máy tính xách tay"
            },
            new Category
            {
                Id = 3,
                Name = "Phụ kiện",
                Description = "Phụ kiện điện tử"
            }
        };

        return View(categories);
    }

    public IActionResult Product()
    {
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "iPhone 16",
                CategoryId = 1,
                Price = 22000000,
                StockQuantity = 10,
                ImageFileName = "iphone16.jpg",
                IsActive = true
            },
            new Product
            {
                Id = 2,
                Name = "Samsung Galaxy",
                CategoryId = 1,
                Price = 15000000,
                StockQuantity = 8,
                ImageFileName = "samsung.jpg",
                IsActive = true
            },
            new Product
            {
                Id = 3,
                Name = "Laptop Dell",
                CategoryId = 2,
                Price = 18000000,
                StockQuantity = 5,
                ImageFileName = "dell.jpg",
                IsActive = true
            },
            new Product
            {
                Id = 4,
                Name = "Chuột không dây",
                CategoryId = 3,
                Price = 350000,
                StockQuantity = 20,
                ImageFileName = "mouse.jpg",
                IsActive = false
            }
        };

        return View(products);
    }

    public IActionResult Employee()
    {
        var employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FullName = "Nguyễn Văn An",
                Phone = "0901234567",
                Email = "an@example.com",
                UserId = "user01",
                IsActive = true
            },
            new Employee
            {
                Id = 2,
                FullName = "Trần Thị Bình",
                Phone = "0912345678",
                Email = "binh@example.com",
                UserId = "user02",
                IsActive = true
            },
            new Employee
            {
                Id = 3,
                FullName = "Lê Văn Nam",
                Phone = "0923456789",
                Email = "nam@example.com",
                UserId = null,
                IsActive = false
            }
        };

        return View(employees);
    }

    public IActionResult Invoice()
    {
        var invoices = new List<Invoice>
        {
            new Invoice
            {
                Id = 1,
                CreatedAt = new DateTime(2026, 10, 20),
                EmployeeId = 1,
                CustomerName = "Nguyễn Minh",
                CustomerPhone = "0981111111",
                TotalAmount = 22350000
            },
            new Invoice
            {
                Id = 2,
                CreatedAt = new DateTime(2026, 10, 21),
                EmployeeId = 2,
                CustomerName = "Trần Lan",
                CustomerPhone = "0982222222",
                TotalAmount = 15000000
            }
        };

        return View(invoices);
    }

    public IActionResult InvoiceDetail()
    {
        var invoiceDetails = new List<InvoiceDetail>
        {
            new InvoiceDetail
            {
                Id = 1,
                InvoiceId = 1,
                ProductId = 1,
                Quantity = 1,
                UnitPrice = 22000000
            },
            new InvoiceDetail
            {
                Id = 2,
                InvoiceId = 1,
                ProductId = 4,
                Quantity = 1,
                UnitPrice = 350000
            },
            new InvoiceDetail
            {
                Id = 3,
                InvoiceId = 2,
                ProductId = 2,
                Quantity = 1,
                UnitPrice = 15000000
            }
        };

        return View(invoiceDetails);
    }
}