using Abby_.Data;
using Abby_.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_.Pages.Categories
{
    

    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            category = _db.Category.Find(id);
        }
        public async Task<IActionResult> OnPost(Category category)
        {
            
                var CategoryFromDb = _db.Category.Find(category.Id);
                if(CategoryFromDb!=null)
                {
                    _db.Category.Remove(CategoryFromDb);
                    await _db.SaveChangesAsync();
                TempData["Success"] = "Category Deleted Successfully";
                return RedirectToPage("index");
                }
            return Page();
                
         
         
        }
    }
}
