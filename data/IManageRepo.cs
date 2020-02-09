using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hohsys.API.models;

namespace hohsys.API.data
{
    public interface IManageRepo
    {
        Task<User> GetUser();
        Task<List<User>> GetAllUsers();
        Task<Boolean> UpdateUser(User user);
        Task<Boolean> ChangeMyPassword(string OldPassword, string NewPassword);
        Task<Boolean> DeleteUser(int UserId);
    }
}