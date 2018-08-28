using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KjemiaWeb.Pages
{
    public class NaturfagsappenAndroidModel : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPostDownloadIOS()
        {
            return File("~/downloads/KjemiaQuiz.ipa", "application/octet-stream",
                        "Naturfagsappen.ipa");
        }
    }
}