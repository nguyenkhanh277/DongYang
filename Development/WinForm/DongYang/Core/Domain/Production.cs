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
        //Xep hang -> Chi scan khi NULL Or Hold -> Luon la Confirm && OK
        //QC -> Chi scan khi Confirm && OK -> Chon OK/NG/Hold
        //QA -> Chi scan khi Check && NG -> Chon OK/NG -> Neu NG thi update Scrap (Vao bang InventoryDetail)
        //Import -> Chi scan khi ((Check && OK) Or (Approve && OK)) -> Luon la Import && OK
        #endregion
    }
}
