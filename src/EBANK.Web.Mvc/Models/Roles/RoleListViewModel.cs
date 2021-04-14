using System.Collections.Generic;
using EBANK.Roles.Dto;

namespace EBANK.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
