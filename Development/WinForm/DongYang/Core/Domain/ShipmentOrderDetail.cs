using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongYang.Core.Domain
{
    public class ShipmentOrderDetail : Base
    {
        #region Fields
        public string Id { get; set; }
        public string ShipmentOrderId { get; set; }
        public string Barcode { get; set; }
        public DateTime ExportedDate { get; set; }
        public float QuantityActual { get; set; }
        //Chi scan duoc khi da Import && remain > 0
        //Thong bao neu can in the tu dong
        //Xe nay con du 30. He thong tu dong tem. Yeu cau dan tem moi len xe
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
