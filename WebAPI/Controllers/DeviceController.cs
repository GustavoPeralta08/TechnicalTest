using AutoMapper;
using Core.Application;
using Core.Data.Domain.TechnicalDbModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        #region Private and protected properties
        private readonly IDeviceLogic _deviceLogic;
        private readonly IMapper _mapperService;
        #endregion

        #region Constructor

        public DeviceController(IDeviceLogic deviceLogic, IMapper mapperService)
        {
            _deviceLogic = deviceLogic;
            _mapperService = mapperService;
        }

        #endregion

        [HttpPost]
        public IActionResult AddDevice(DeviceViewModel deviceLogic)
        {
            var device = _mapperService.Map<DeviceLogical>(deviceLogic);
            bool add = _deviceLogic.AddDevice(device);

            if (add)
                return Ok(new { message = "successfully created" });
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<DeviceLogical>> GetDevice(int? deviceTypeId)
        {
            var devices = _deviceLogic.GetDevice(deviceTypeId);
            return Ok(_mapperService.Map<IEnumerable<DeviceViewModel>>(devices));
        }

        [HttpGet("{id}")]
        public IActionResult GetDeviceById(int id)
        {
            var device = _deviceLogic.GetDeviceById(id);
            return Ok(_mapperService.Map<DeviceViewModel>(device));
        }

        [HttpPut]
        public IActionResult UpdateDevice(DeviceViewModel deviceLogical)
        {
            var device = _mapperService.Map<DeviceLogical>(deviceLogical);
            bool update = _deviceLogic.UpdateDevice(device);
            if (update)
                return Ok(new { message = "successfully update" });
            else
                return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDevice(int id)
        {
            bool delete = _deviceLogic.DeleteDevice(id);
            if (delete)
                return Ok(new { message = "successfully deleted" });
            else
                return BadRequest();
            
        }
    }
}