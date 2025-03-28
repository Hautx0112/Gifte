﻿using Microsoft.EntityFrameworkCore;
using Gifte.Repositories.Base;
using Gifte.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifte.Repositories
{
    public class UserRepository : GenericRepository<UserAccount>
    {
        public UserRepository() { }

        public async Task<UserAccount> GetUserAccount(string email, string password)
        {
            return await _context.UserAccounts.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public async Task<UserAccount> GetUserByEmail(string email)
        {
            return await _context.UserAccounts.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<UserAccount> CreateUser(UserAccount user)
        {
            await _context.UserAccounts.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }

}
