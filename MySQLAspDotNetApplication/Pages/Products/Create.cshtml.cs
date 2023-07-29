using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySQLAspDotNetApplication.Data;
using MySQLAspDotNetApplication.Model;

namespace MySQLAspDotNetApplication.Pages.Products
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public Product product { get; set; }

        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        // Get Handler method
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Product.AddAsync(product);
                await _db.SaveChangesAsync(); // to permannently save the data into the database
                TempData["success"] = "Product Added Successfully";
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
