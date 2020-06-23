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
    public class EquipmentRepository : IEquipmentRepository
    {
        AnbarDbContext _db;
        public async Task<bool> Add(Equipment item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    _db.Equipments.Add(item);
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
                    var find = await _db.Equipments.Where(a => a.Id == Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        _db.Equipments.Remove(find);
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

        public async Task<List<Equipment>> GetAll()
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Equipments.ToListAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<Equipment> GetItem(Expression<Func<Equipment, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Equipments.Where(where).FirstOrDefaultAsync();

                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<List<Equipment>> GetSelect(Expression<Func<Equipment, bool>> where)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    return await _db.Equipments.Where(where).ToListAsync();
                }
                catch (Exception ex)
                {

                }
                return null;
            }
        }

        public async Task<Equipment> Update(Equipment item)
        {
            using (_db = new AnbarDbContext())
            {
                try
                {
                    var find = await _db.Equipments.Where(a => a.Id == item.Id).FirstOrDefaultAsync();
                    if (find != null)
                    {
                        find.AmvalNumber = item.AmvalNumber;
                        find.Model = item.Model;
                        find.Serial = item.Serial;
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
