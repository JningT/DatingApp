using DataApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApp.Data
{
    public interface IAuthRepository
    {
        Task<User> Regeister(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExist(String username);
        
    }
}
