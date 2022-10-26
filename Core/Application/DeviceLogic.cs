using Core.Data.Domain.TechnicalDbModel;
using Core.Data.Repositories;
using System.Collections.Generic;

namespace Core.Application
{
    public class DeviceLogic : IDeviceLogic
    {
        #region Private and protected properties

        private readonly IDeviceRepository _deviceRepository;

        #endregion

        #region Constructor

        public DeviceLogic(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        #endregion

        public bool AddDevice(DeviceLogical deviceLogical)
        {
            return _deviceRepository.AddDevice(deviceLogical);
        }

        public bool DeleteDevice(int id)
        {
            return _deviceRepository.DeleteDevice(id);
        }

        public IEnumerable<DeviceLogical> GetDevice(int? deviceTypeId)
        {
            return _deviceRepository.GetDevice(deviceTypeId);
        }

        public DeviceLogical GetDeviceById(int id)
        {
            return _deviceRepository.GetDeviceById(id);
        }

        public bool UpdateDevice(DeviceLogical deviceLogical)
        {
            return _deviceRepository.UpdateDevice(deviceLogical);
        }

        


    }
}