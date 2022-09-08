using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Service;

namespace WebAppDETAug2022.Pages
{
    public class HelloPageModel : PageModel
    {
        public Hello2 ob { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            ob = new Hello2();
            Message = ob.SayHello ("shilpa");
        }
    }
}
