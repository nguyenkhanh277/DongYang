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
    public class ShipmentOrderRepository : Repository<ShipmentOrder>
    {
        public string id = "";

        public ShipmentOrderRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(ShipmentOrder shipmentOrder)
        {
            if (String.IsNullOrEmpty(shipmentOrder.Id))
            {
                shipmentOrder.Id = GetAutoID();
                shipmentOrder.CompletedStatus = GlobalConstants.CompletedStatusValue.None;
                shipmentOrder.Status = GlobalConstants.StatusValue.Using;
                shipmentOrder.CreatedAt = DateTime.Now;
                shipmentOrder.CreatedBy = GlobalConstants.username;
                Add(shipmentOrder);
                id = shipmentOrder.Id;
            }
            else
            {
                Update(shipmentOrder);
            }
        }

        public void Update(ShipmentOrder shipmentOrder)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(shipmentOrder.Id));
                if (raw != null)
                {
                    raw.CollectInformation(shipmentOrder);
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

        public void UpdateStatus(string id, GlobalConstants.StatusValue status)
        {
            error = false;
            errorMessage = "";
            try
            {
                var workOrder = FirstOrDefault(_ => _.Id.Equals(id));
                if (workOrder != null)
                {
                    workOrder.Status = status;
                    workOrder.EditedAt = DateTime.Now;
                    workOrder.EditedBy = GlobalConstants.username;
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