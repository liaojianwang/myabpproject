﻿using System.Collections.Generic;
using MyAbpProject.Roles.Dto;

namespace MyAbpProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
