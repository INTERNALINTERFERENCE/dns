using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShell_blazor.Models;

namespace WebShell_blazor.Data.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly BashContext _context;

        public SqlRepository(BashContext context)
        {
            _context = context;
        }

        public void AddBashCommand(string bashCommand)
        {
            BashData bashData = new BashData()
            {
                BashCommand = bashCommand
            };
            _context.BashCommands.Add(bashData);
            _context.SaveChanges();
        }                  

        public void GetAllCommands(List<string> value)
        {
            var query =
                from x in _context.BashCommands
                select x.BashCommand;
            foreach(var item in query)
            {
                value.Add(item);
            }
        }
    }
}
