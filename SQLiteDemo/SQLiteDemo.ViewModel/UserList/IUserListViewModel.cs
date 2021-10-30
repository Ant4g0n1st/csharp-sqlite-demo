﻿using SQLiteDemo.Model.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.UserList
{
    interface IUserListViewModel
    {

        Task<IEnumerable<IUserModel>> GetAllUsers();

    }
}
