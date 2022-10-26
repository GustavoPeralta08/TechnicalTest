using Core.Data.Domain.TechnicalDbModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Data.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        #region Private and protected properties

        private readonly TechnicalTestDBContext _dbContext;
        private readonly DbSet<DeviceLogical> _entities;

        #endregion

        #region Constructor

        public DeviceRepository(TechnicalTestDBContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<DeviceLogical>();
        }
        #endregion

        public bool AddDevice(DeviceLogical deviceLogical)
        {
            try
            {
                _entities.Add(deviceLogical);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public bool DeleteDevice(int id)
        {
            try
            {
                DeviceLogical device = _entities.Find(id);
                _entities.Remove(device);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<DeviceLogical> GetDevice(int? deviceTypeId)
        {
            try
            {
                if(deviceTypeId != null)
                {
                    return _entities.Where(x=> x.DeviceTypeId == deviceTypeId).ToList();
                }
                else
                {
                    return _entities.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DeviceLogical GetDeviceById(int id)
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateDevice(DeviceLogical deviceLogical)
        {
            try
            {
                _entities.Update(deviceLogical);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        


    }
}