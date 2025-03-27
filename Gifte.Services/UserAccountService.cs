using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gifte.Repositories;
using Gifte.Repositories.Models;

namespace Gifte.Services
{
    public interface IUserAccountService
    {
        Task<UserAccount> Authenticate(string email, string password);
        Task<UserAccount> RegisterUser(UserAccount user);
        Task<UserAccount> FindByEmail(string email);
    }

    public class UserAccountService : IUserAccountService
    {
        private readonly UserRepository _userRepo;

        public UserAccountService() => _userRepo = new UserRepository();

        public async Task<UserAccount> Authenticate(string email, string password)
        {
            return await _userRepo.GetUserAccount(email, password);
        }

        public async Task<UserAccount> RegisterUser(UserAccount user)
        {
            return await _userRepo.CreateUser(user);
        }

        public async Task<UserAccount> FindByEmail(string email)
        {
            return await _userRepo.GetUserByEmail(email);
        }
    }

}

