using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Data;
using SallesWebMvc.Services;

namespace SallesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        SallesWebMvcContext _context;
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        //GET: Sellers
        public  IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
