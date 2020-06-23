using DataLayer;
using DomainLayer;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        AnbarDbContext _db;
        public async Task<bool> Add(User item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    _db.Users.Add(item);
                    await _db.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }

        public async Task<bool> Delete(int Id)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    var find=await _db.Users.Where(a=>a.Id==Id).FirstOrDefaultAsync();
                    if (find!=null)
                    {
                        _db.Users.Remove(find);
                        await _db.SaveChangesAsync();
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }

        public async Task<List<User>> GetAll()
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Users.ToListAsync();
                    
                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }


        public async Task<User> GetItem(Expression<Func<User, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Users.Where(where).FirstOrDefaultAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<List<User>> GetSelect(Expression<Func<User, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Users.Where(where).ToListAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<bool> Login(string username, string password)
        {
            using (_db=new AnbarDbContext())
            {
                var find = await _db.Users.FirstOrDefaultAsync(a => a.Username == username && a.Password == password);
                if (find != null)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<User> Update(User item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    var find = await _db.Users.Where(a => a.Id == item.Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        find.Name = item.Name;
                        find.Password = item.Password;
                        find.Username = item.Username;
                        await _db.SaveChangesAsync();
                        return find;
                    }
                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }
    }
}
