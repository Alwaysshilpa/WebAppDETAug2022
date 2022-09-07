using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; }
        public int Discount { get; set; }
        public void OnGet()
        {
            Message = " ASP.Net Core is Rocking!! ";
            Discount = 15;
        }
        }
    }

