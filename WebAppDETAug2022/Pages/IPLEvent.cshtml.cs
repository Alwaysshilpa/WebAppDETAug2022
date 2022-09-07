using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        public void OnGet()
        {
            Tickets = new list<Ticket>
            {
                new Ticket{ Id= 1, Name = "Movie1",Price=5000},
                   new Ticket{ Id= 2, Name = "Movie2",Price=4000},

            };
        }
    }
}
