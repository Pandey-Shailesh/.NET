using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySQLAspDotNetApplication.Data;
using MySQLAspDotNetApplication.Model;

namespace MySQLAspDotNetApplication.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IEnumerable<Product> Products { get; set; }

        public IndexModel(ApplicationDBContext db) 
        { 
            _db = db;
        }

        //Get Handler method
        public void OnGet()
        {
            Products = _db.Product;
        }
    }
}
