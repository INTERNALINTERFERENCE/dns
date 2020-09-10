using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShell_blazor.Models;

namespace WebShell_blazor.Data.Repository
{
    public interface IRepository
    {
        void AddBashCommand(string value);
        void GetAllCommands(List<string> value);
    }
}
