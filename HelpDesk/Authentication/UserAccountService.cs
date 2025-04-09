using HelpDesk.Models;
using System.Linq;

namespace HelpDesk.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;
        private List<UserAccount> _suppliers;
        private List<UserAccount> _admins;
        private readonly HelpDeskContext _context;

        public UserAccountService(HelpDeskContext context)
        {
            _context = context;

            _users = _context.Users.Select(user => new UserAccount
            {
                UserName = user.Login,
                Password = user.Password,
                Role = "User"
            }).ToList();

            _suppliers = _context.Supliers.Select(supplier => new UserAccount
            {
                UserName = supplier.Login,
                Password = supplier.Password,
                Role = "Supplier"
            }).ToList();

            _admins = _context.Admins.Select(admin => new UserAccount
            {
                UserName = admin.Login,
                Password = admin.Password,
                Role = "Administrator"
            }).ToList();
        }

        public UserAccount? GetByUserName(string userName)
        {
            var user = _users.FirstOrDefault(x => x.UserName == userName);
            if (user != null)
            {
                return user;
            }

            var supplier = _suppliers.FirstOrDefault(x => x.UserName == userName);
            if (supplier != null)
            {
                return supplier;
            }

            var admin = _admins.FirstOrDefault(x => x.UserName == userName);
            return admin;
        }
    }
}
