using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongYang.Core.Domain
{
    public class Product : Base
    {
        #region Fields
        public string Id { get; set; }
        public string PartNumber { get; set; }
        public string Model { get; set; }
        public string PartName { get; set; }
        public string PartNameShort { get; set; }
        [NotMapped]
        public string Datas { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
