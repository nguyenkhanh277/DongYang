using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongYang.Core.Domain
{
    public class Production : Base
    {
        #region Fields
        public string Id { get; set; }
        public string Barcode { get; set; }
        public DateTime ScanDate { get; set; }
        public GlobalConstants.ProductionStatusValue ProductionStatus { get; set; }
        public GlobalConstants.ActionValue Action { get; set; }
        #endregion
    }
}
