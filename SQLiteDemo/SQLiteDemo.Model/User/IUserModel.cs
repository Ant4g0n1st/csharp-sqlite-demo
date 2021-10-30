using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Model.User
{
    interface IUserModel
    {
        string Name { get; set; }
        string LastName { get; set; }
    }
}
