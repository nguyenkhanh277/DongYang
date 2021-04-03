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
                workOrder.QuantityPerCart = 0;
                workOrder.Status = GlobalConstants.StatusValue.Using;
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

        public List<ReportWorkOrder> GetReportWorkOrder(DateTime fromDate, DateTime toDate)
        {
            var workOrders = from x in ProjectDataContext.WorkOrders
                             where x.WorkOrderDate >= fromDate && x.WorkOrderDate <= toDate && x.Status == GlobalConstants.StatusValue.Using
                             orderby x.WorkOrderDate, x.PartNumber
                             select new { x };

            var inventorys = from x in ProjectDataContext.Inventorys
                             join y in ProjectDataContext.WorkOrders on x.WorkOrderId equals y.Id
                             where y.WorkOrderDate >= fromDate && y.WorkOrderDate <= toDate && x.CompletedStatus == GlobalConstants.CompletedStatusValue.OK
                             select new { x, y };

            //var shipmentOrderDetails = from x in ProjectDataContext.ShipmentOrderDetails
            //                           join y in ProjectDataContext.ShipmentOrders on x.ShipmentOrderId equals y.Id
            //                           where x.ExportedDate >= fromDate && x.ExportedDate <= toDate && x.Status == GlobalConstants.StatusValue.Using
            //                           select new { x, y };

            List<ReportWorkOrder> reportWorkOrders = new List<ReportWorkOrder>();
            if (workOrders.Any())
            {
                ReportWorkOrder reportWorkOrder;
                foreach (var item in workOrders)
                {
                    reportWorkOrder = new ReportWorkOrder();
                    reportWorkOrder.WorkOrderDate = item.x.WorkOrderDate.Date;
                    reportWorkOrder.PartNumber = item.x.PartNumber;
                    reportWorkOrder.Model = item.x.Model;
                    reportWorkOrder.PartName = item.x.PartName;
                    reportWorkOrder.PartNameShort = item.x.PartNameShort;
                    reportWorkOrder.QuantityOrder = item.x.Quantity;
                    if (inventorys.Any())
                    {
                        reportWorkOrder.QuantityImport = inventorys.Where(_ => _.y.PartNumber.Equals(item.x.PartNumber)).Select(_ => _.x.QuantityActual).Sum();
                    }
                    else
                    {
                        reportWorkOrder.QuantityImport = 0;
                    }
                    reportWorkOrder.QuantityRemain = reportWorkOrder.QuantityOrder - reportWorkOrder.QuantityImport;
                    //if (shipmentOrderDetails.Any())
                    //{
                    //    reportWorkOrder.QuantityExport = shipmentOrderDetails.Where(_ => _.y.PartNumber.Equals(item.x.PartNumber)).Select(_ => _.x.QuantityActual).Sum();
                    //}
                    //else
                    //{
                    //    reportWorkOrder.QuantityExport = 0;
                    //}
                    reportWorkOrders.Add(reportWorkOrder);
                }
            }
            return reportWorkOrders;
        }
    }
}