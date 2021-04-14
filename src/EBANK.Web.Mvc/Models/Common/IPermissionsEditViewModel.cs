using System.Collections.Generic;
using EBANK.Roles.Dto;

namespace EBANK.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}