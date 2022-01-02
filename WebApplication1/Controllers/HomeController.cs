using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.DepartmentList = new List<DbSetTable>() { new DbSetTable( 1, "HR") , new DbSetTable(2, "IT")  , new DbSetTable( 3, "Manager")  };
            ViewBag.CostCenterList = new List<DbSetTable>() { new DbSetTable(1, "CostCenter 001" ), new DbSetTable(2, "CostCenter 002" ), new DbSetTable(3, "CostCenter 003" ) };
            ViewBag.CurrencyList =  new List<DbSetTable>() { new DbSetTable(1, "$" ), new DbSetTable(2, "£" ) };

            ViewBag.Vendors = new List<DbSetTable>() { new DbSetTable(1, "Vendor 002"), new DbSetTable(2, "Vendor 002") };
            ViewBag.Items = new List<DbSetTable>() { new DbSetTable(1, "Item 002"), new DbSetTable(2, "Item 002") };
            ViewBag.Units = new List<DbSetTable>(){ new DbSetTable(1, "Unit 001"), new DbSetTable(2, "Unit 002"), new DbSetTable(2, "Unit 003"), new DbSetTable(2, "Unit 004") }; 
              
            return View();
        }



        [HttpPost]
        public ActionResult Index(PurchaseRequest purchaseRequest, List<PurchaseRequest_Items> items )
        {
            if (ModelState.IsValid)
            {
                //purchaseRequest.Status = "Under-Create";
                //purchaseRequest.CreatedBy = settings.CurrentUser_AX;
                //purchaseRequest.CreatedDate = DateTime.Now;
                //db.PurchaseRequests.Add(purchaseRequest);

                //db.SaveChanges();

                //db.PurchaseRequest_Items.RemoveRange(db.PurchaseRequest_Items.Where(c => c.PurchaseRequest_id == purchaseRequest.id));
                //db.SaveChanges();

                //db.PurchaseRequest_RecommendedVendors.RemoveRange(db.PurchaseRequest_RecommendedVendors.Where(c => c.PurchaseRequest_id == purchaseRequest.id));
                //db.SaveChanges();

                //if (items != null)
                //{
                //    foreach (var item in items)
                //    {
                //        item.PurchaseRequest_id = purchaseRequest.id;
                //        db.PurchaseRequest_Items.Add(item);
                //        db.SaveChanges();
                //    }
                //}
                //if (recommendedvendors != null)
                //{
                //    foreach (var vendor in recommendedvendors)
                //    {
                //        vendor.PurchaseRequest_id = purchaseRequest.id;
                //        db.PurchaseRequest_RecommendedVendors.Add(vendor);
                //        db.SaveChanges();
                //    }
                //}

                return RedirectToAction("PurchaseRequest");
            } 
            return View(purchaseRequest);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    public class DbSetTable
    {
        public DbSetTable()
        {
        }

        public DbSetTable(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id{ get; set; }
        public string Name{ get; set; }
    }

}