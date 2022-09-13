using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDemo.Controllers.Models;

namespace APIDemo.Data
{
    public class APIDemoContext : DbContext
    {
        public APIDemoContext (DbContextOptions<APIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<APIDemo.Controllers.Models.User> User { get; set; } = default!;

        public DbSet<APIDemo.Controllers.Models.ToDoItem>? ToDoItem { get; set; }
    }
}
