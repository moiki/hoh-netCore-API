using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hohsys.API.helpers;
using hohsys.API.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace hohsys.API.data
{
    public class ManageRepo : IManageRepo
    {
        private readonly UserManager<User> userManager;
        private readonly HoHDbContext db;
        private readonly IGetCurrentUserService gcu;
        public ManageRepo(UserManager<User> _userManager, HoHDbContext _db, IGetCurrentUserService _gcu)
        {
            gcu = _gcu;
            db = _db;
            userManager = _userManager;

        }

        public async Task<bool> ChangeMyPassword(string OldPassword, string NewPassword)
        {
            var currentUser = await userManager.FindByNameAsync(gcu.GetCurrentUserName());
            var changePassword = await userManager
                                    .ChangePasswordAsync(currentUser, OldPassword, NewPassword);
            return changePassword.Succeeded;
        }

        public async Task<bool> DeleteUser(int UserId)
        {
            var ud = await db.Users.FirstOrDefaultAsync(u => u.Id == UserId);
            ud.IsActive = false;
            db.Users.Update(ud);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await db.Users.ToListAsync();
        }

        public async Task<User> GetUser()
        {
            var cu = await userManager.FindByNameAsync(gcu.GetCurrentUserName());
            return cu;
        }

        public async Task<bool> UpdateUser(User user)
        {
            var result = await userManager.UpdateAsync(user);
            return result.Succeeded;
        }
    }
}