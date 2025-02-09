using BookApp.Models;
using BookAppWebRezor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookAppWebRezor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        //[BindProperty]
        private readonly ApplicationDbContexRezor _db;
        public Category? Category { get; set; }

        public EditModel(ApplicationDbContexRezor db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }
        //[BindProperty]
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
