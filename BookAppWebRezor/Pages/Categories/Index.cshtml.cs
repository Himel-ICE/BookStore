using BookApp.Models;
using BookAppWebRezor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookAppWebRezor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContexRezor _db;
        public List<Category> CategoryList {get;set;}
        public IndexModel(ApplicationDbContexRezor db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
