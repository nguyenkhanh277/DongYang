using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongYang.Core.Domain
{
    public class Inventory : Base
    {
        #region Fields
        public string Id { get; set; }
        public string WorkOrderId { get; set; }
        public DateTime PrintedDate { get; set; }
        public string Barcode { get; set; }
        //Model + PartNumber + WorkOrderDate (ddMMyyHHmm) + WorkOrderNo + SEQ
        //Example:
        //  + Model: SS
        //  + P/N: Notebook7
        //  + Name: DTDD
        //  + WO: XXX
        //  + Date: 31/03/2021
        //  + Quantity: 50
        public float QuantityActual { get; set; }
        public float QuantityRemain { get; set; }
        public GlobalConstants.CompletedStatusValue CompletedStatus { get; set; }
        #endregion
    }
}
