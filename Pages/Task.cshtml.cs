using System.Diagnostics.Metrics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab3.Pages
{
    public class TaskModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<string> Tasks { get; set; } = new List<string>();
        public IActionResult OnPost()
        {
            string text = Request.Form["TaskText"];
            Tasks.Add(text);

            Console.WriteLine("------");
            foreach (string Task in Tasks)
            {
            Console.WriteLine(Task);
            }

            Console.WriteLine("------^");
            return RedirectToPage("/Index", new { Tasks =this.Tasks });
        }
        public void OnGet()
        {

        }
    }
}
