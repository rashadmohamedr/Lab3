using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<string> Tasks { get; set; } = new List<string>();
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/Task", new { Tasks = this.Tasks });
        }
    }
}