using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Model.User
{
    class UserModel : IUserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
