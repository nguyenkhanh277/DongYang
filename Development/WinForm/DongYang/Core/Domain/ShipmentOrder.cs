using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongYang.Core.Domain
{
    public class ShipmentOrder : Base
    {
        #region Fields
        public string Id { get; set; }
        public DateTime ShipmentOrderDate { get; set; }
        public string Model { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public string PartNameShort { get; set; }
        public float Quantity { get; set; }
        public GlobalConstants.CompletedStatusValue CompletedStatus { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
