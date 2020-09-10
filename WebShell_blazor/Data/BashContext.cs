using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShell_blazor.Models;

namespace WebShell_blazor.Data
{
    public class BashContext : DbContext
    {
        public BashContext(DbContextOptions<BashContext> options)
           : base(options) { }

        public DbSet<BashData> BashCommands { get; set; }
    }
}
