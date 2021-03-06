﻿using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUERM_RRS.Repositories
{
    public interface IRoleRepository
    {
        void Insert(Guid id, string role);
        void InsertMany(Guid id, List<RoleViewModel> roles);
        void Update(RoleViewModel roleViewModel);
        void Delete(RoleViewModel roleViewModel);
        void DeleteRoleByUserName(string username);
        List<RoleViewModel> GetAllRoles();
        List<RoleViewModel> GetRolesByUsername(string username);
        void Dispose();
    }
}
