using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Product> AllProducts = _context.Products.ToList();
        ViewBag.AllProducts = AllProducts;
        return View();
    }

    [HttpPost(template: "products/create")]
    public IActionResult CreateProduct(Product newProduct)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        List<Product> AllProducts = _context.Products.ToList();
        ViewBag.AllProducts = AllProducts;
        return View("Index");
    }

    [HttpGet("products/{ProductId}")]
    public IActionResult ViewP(int ProductId)
    {
        Product? ThisProduct = _context.Products.Include(p => p.MyCategories).ThenInclude(s => s.Category).FirstOrDefault(p => p.ProductId == ProductId);
        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View("ViewProduct", ThisProduct);
    }

    [HttpGet("category/{CategoryId}")]
    public IActionResult ViewC(int CategoryId)
    {
        Category? ThisCategory = _context.Categories.Include(p => p.MyProducts).ThenInclude(s => s.Product).FirstOrDefault(p => p.CategoryId == CategoryId);
        List<Product> AllProducts = _context.Products.ToList();
        ViewBag.AllProducts = AllProducts;
        return View("ViewCategory", ThisCategory);
    }

    [HttpPost("associations/create")]
    public IActionResult AddAssociation(Association newAssociation)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newAssociation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("Index");
    }
    public IActionResult Privacy()
    {
        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View();
    }

    [HttpPost(template: "categories/create")]
    public IActionResult CreateCategory(Category newCategory)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Privacy");
        }
        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View("Privacy");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}