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
    public class DeviceTypeRepository : IDeviceTypeRepository
    {
        AnbarDbContext _db;
        public async Task<bool> Add(DeviceType item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    _db.DeviceTypes.Add(item);
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
                    var find = await _db.DeviceTypes.Where(a => a.Id == Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        _db.DeviceTypes.Remove(find);
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

        public async Task<List<DeviceType>> GetAll()
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.DeviceTypes.ToListAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<DeviceType> GetItem(Expression<Func<DeviceType, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.DeviceTypes.Where(where).FirstOrDefaultAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<List<DeviceType>> GetSelect(Expression<Func<DeviceType, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.DeviceTypes.Where(where).ToListAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<DeviceType> Update(DeviceType item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    var find = await _db.DeviceTypes.Where(a => a.Id == item.Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        find.Name = item.Name;
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
