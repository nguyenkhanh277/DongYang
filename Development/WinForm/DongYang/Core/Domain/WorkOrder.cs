using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongYang.Core.Domain
{
    public class WorkOrder : Base
    {
        #region Fields
        public string Id { get; set; }
        public string WorkOrderNo { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public string PartNumber { get; set; }
        public string Model { get; set; }
        public string PartName { get; set; }
        public string PartNameShort { get; set; }
        public float Quantity { get; set; }
        public float QuantityPerCart { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        [NotMapped]
        public string PrintBarcode { get; set; } = "In mã vạch";
        #endregion
    }
}
