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
    public class DeviceRepository : IDeviceRepository
    {
        AnbarDbContext _db;
        public async Task<bool> Add(Device item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    _db.Devices.Add(item);
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
                    var find = await _db.Devices.Where(a => a.Id == Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        _db.Devices.Remove(find);
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

        public async Task<List<Device>> GetAll()
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Devices.ToListAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<Device> GetItem(Expression<Func<Device, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Devices.Where(where).FirstOrDefaultAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<List<Device>> GetSelect(Expression<Func<Device, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Devices.Where(where).ToListAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<Device> Update(Device item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    var find = await _db.Devices.Where(a => a.Id == item.Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        find.AmvalNumber = item.AmvalNumber;
                        find.Model = item.Model;
                        find.Serial = item.Serial;
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
