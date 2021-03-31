using DongYang.Core.Domain;
using DongYang.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using DongYang.Core;
using DongYang.Core.Helper;
using System.Threading;
using System.Data;

namespace DongYang.Persistence.Repositories
{
    public class ShipmentOrderDetailRepository : Repository<ShipmentOrderDetail>
    {
        public string id = "";

        public ShipmentOrderDetailRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(ShipmentOrderDetail shipmentOrderDetail)
        {
            if (String.IsNullOrEmpty(shipmentOrderDetail.Id))
            {
                shipmentOrderDetail.Id = GetAutoID();
                shipmentOrderDetail.CreatedAt = DateTime.Now;
                shipmentOrderDetail.CreatedBy = GlobalConstants.username;
                Add(shipmentOrderDetail);
                id = shipmentOrderDetail.Id;
            }
            else
            {
                Update(shipmentOrderDetail);
            }
        }

        public void Update(ShipmentOrderDetail shipmentOrderDetail)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(shipmentOrderDetail.Id));
                if (raw != null)
                {
                    raw.CollectInformation(shipmentOrderDetail);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}