using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CorePractice.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string[] names = new string[] { "Alfreda Stephenson",
                  "Swanson Swanson",
                  "Walker Pace",
                  "Katina Le",
                  "Lesley Calderon",
                  "Ruth Merrill",
                  "Cristina Buchanan",
                  "Gallegos May",
                  "Macdonald Lucas"};
            int num = 3;
            int[] age = new int[num];
            string[] name = new string[num];
            int[] family = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                age[i] = rnd.Next(50);
                name[i] = names[rnd.Next(names.Length)];
                family[i] = rnd.Next(5);
            }
            ViewData["age"] = age;
            ViewData["name"] = name;
            ViewData["family"] = family;
        }
    }
}
