using System.Collections.Generic;
using MyAbpProject.Roles.Dto;

namespace MyAbpProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}