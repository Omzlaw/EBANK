using System.Collections.Generic;
using EBANK.Roles.Dto;

namespace EBANK.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
