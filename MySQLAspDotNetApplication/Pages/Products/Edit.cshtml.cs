using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySQLAspDotNetApplication.Data;
using MySQLAspDotNetApplication.Model;

namespace MySQLAspDotNetApplication.Pages.Products
{
   
        [BindProperties]
        public class EditModel : PageModel
        {
            private readonly ApplicationDBContext _db;

            public Product product { get; set; }

            public EditModel(ApplicationDBContext db)
            {
                _db = db;
            }

            // Get Handler method
            public void OnGet(object?[]? id)
            {
            product = _db.Product.Find(id);
            }

            public async Task<IActionResult> OnPost()  
            {
                if (ModelState.IsValid)
                {
                    await _db.Product.Update(product);
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
