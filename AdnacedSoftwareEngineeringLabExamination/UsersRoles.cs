using System;
using System.Collections.Generic;

namespace OOPDemo
{
    public class UsersRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        public bool AssignRoleToUSer(int userId,int roleId)
        {
            throw new NotImplementedException();
        }
        public bool CheckUserInRole(int userId, int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
