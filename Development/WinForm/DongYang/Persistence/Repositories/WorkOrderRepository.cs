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
    public class WorkOrderRepository : Repository<WorkOrder>
    {
        public string id = "";

        public WorkOrderRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(WorkOrder workOrder)
        {
            if (String.IsNullOrEmpty(workOrder.Id))
            {
                workOrder.Id = GetAutoID();
                workOrder.CreatedAt = DateTime.Now;
                workOrder.CreatedBy = GlobalConstants.username;
                Add(workOrder);
                id = workOrder.Id;
            }
            else
            {
                Update(workOrder);
            }
        }

        public void Update(WorkOrder workOrder)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(workOrder.Id));
                if (raw != null)
                {
                    raw.CollectInformation(workOrder);
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