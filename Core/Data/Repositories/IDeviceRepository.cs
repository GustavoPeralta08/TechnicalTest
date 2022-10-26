using Core.Data.Domain.TechnicalDbModel;
using System.Collections.Generic;

namespace Core.Data.Repositories
{
    public interface IDeviceRepository
    {
        IEnumerable<DeviceLogical> GetDevice(int? deviceTypeId);
        DeviceLogical GetDeviceById(int id);
        bool AddDevice(DeviceLogical deviceLogical);
        bool UpdateDevice(DeviceLogical deviceLogical);
        bool DeleteDevice(int id);

    }
}