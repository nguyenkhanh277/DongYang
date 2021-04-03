using System;
using System.Collections.ObjectModel;

namespace DongYang.Core.Domain
{
    public class ReportWorkOrder
    {
        #region Fields
        public DateTime WorkOrderDate { get; set; }
        public string PartNumber { get; set; }
        public string Model { get; set; }
        public string PartName { get; set; }
        public string PartNameShort { get; set; }
        public float QuantityOrder { get; set; }
        public float QuantityImport { get; set; }
        public float QuantityRemain { get; set; }
        #endregion
    }
}
