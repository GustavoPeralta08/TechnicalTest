using System;

namespace WebAPI.ViewModels
{
    public class DeviceViewModel
    {
        public int DeviceLogicalId { get; set; }
        public int DeviceTypeId { get; set; }
        public int ParentId { get; set; }
        public int ProjectId { get; set; }
        public string DeviceLogicalName { get; set; }
        public string AssetCode { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
    }
}
