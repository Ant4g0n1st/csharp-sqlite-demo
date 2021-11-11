using SQLiteDemo.Model.User;
using System;

namespace SQLiteDemo.DataAccess.Common.Events
{
    public class UserModelEventArgs : EventArgs
    {
        public IUserModel User { get; set; }
    }
}
