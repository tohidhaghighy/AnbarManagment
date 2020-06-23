using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IUserRepository:IRepository<User>
    {
        Task<Boolean> Login(string username, string password);
    }
}
