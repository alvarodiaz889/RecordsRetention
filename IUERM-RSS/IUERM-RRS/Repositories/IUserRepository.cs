﻿using IUERM_RRS.Models;
using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUERM_RRS.Repositories
{
    public interface IUserRepository
    {
        void Insert(UserViewModel userViewModel);
        ApplicationUser InsertDefaultApplicationUser(string username);
        void Update(UserViewModel userViewModel);
        void Delete(UserViewModel userViewModel);
        List<UserViewModel> GetAllUsers();
        UserViewModel GetUserByUserName(string userName);
        void Dispose();

    }
}
