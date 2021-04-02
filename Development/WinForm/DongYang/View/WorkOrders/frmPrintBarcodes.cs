using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DongYang.Persistence;
using DongYang.Persistence.Repositories;
using DongYang.Core.Domain;
using DongYang.Core;
using DongYang.Core.Helper;

namespace DongYang.View.WorkOrders
{
    public partial class frmPrintBarcodes : XtraForm
    {
        ProjectDataContext _projectDataContext;
        WorkOrderRepository _workOrderRepository;
        InventoryRepository _inventoryRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.KeyCode == Keys.F1)
            {
                btnIn_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string _id = "";
        public frmPrintBarcodes(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmPrintBarcodes_Load(object sender, EventArgs e)
        {
            _projectDataContext = new ProjectDataContext();
            _workOrderRepository = new WorkOrderRepository(_projectDataContext);
            _inventoryRepository = new InventoryRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            if (String.IsNullOrEmpty(_id))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa chọn dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                GetData();
            }
        }

        private void GetData()
        {
            //Get Data Table WorkOrder
            WorkOrder workOrder = _workOrderRepository.Get(_id);
            txtWorkOrderNo.Text = workOrder.WorkOrderNo;
            dtpWorkOrderDate.Value = workOrder.WorkOrderDate;
            txtPartNumber.Text = workOrder.PartNumber;
            txtModel.Text = workOrder.Model;
            txtPartNameShort.Text = workOrder.PartNameShort;
            txtQuantity.Value = (decimal)workOrder.Quantity;
            txtQuantityPerCart.Value = (decimal)workOrder.QuantityPerCart;
        }

        private bool CheckData()
        {
            if (txtQuantityPerCart.Value == 0)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }
            return true;
        }

        private void PrintBarcode()
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table WorkOrder
                WorkOrder workOrder = new WorkOrder();
                workOrder.Id = _id;
                workOrder.Quantity = (float)txtQuantity.Value;
                workOrder.QuantityPerCart = (float)txtQuantityPerCart.Value;
                workOrder.Status = GlobalConstants.StatusValue.Using;
                _workOrderRepository.Save(workOrder);

                //Table Barcode
                DataTable dtbBarcode = new DataTable();
                dtbBarcode.Columns.Add("Barcode", typeof(string));
                dtbBarcode.Columns.Add("WorkOrderNo", typeof(string));
                dtbBarcode.Columns.Add("WorkOrderDate", typeof(string));
                dtbBarcode.Columns.Add("Quantity", typeof(string));
                dtbBarcode.Columns.Add("Model", typeof(string));
                dtbBarcode.Columns.Add("PartNumber", typeof(string));
                dtbBarcode.Columns.Add("PartNameShort", typeof(string));
                float quantity = (float)txtQuantity.Value;
                float quantityPerCart = (float)txtQuantityPerCart.Value;
                float actual = 0;
                string barcode = "";
                int seq = 0;
                while (quantity > 0)
                {
                    //Calculate
                    seq++;
                    if (quantity > quantityPerCart)
                    {
                        actual = quantityPerCart;
                        quantity -= actual;
                    }
                    else
                    {
                        actual = quantity;
                        quantity = 0;
                    }
                    barcode = String.Format("{0}{1}{2}{3}{4}",
                            txtModel.Text.Trim(),
                            txtPartNumber.Text.Trim(),
                            dtpWorkOrderDate.Value.ToString("ddMMyyHHmm"),
                            txtWorkOrderNo.Text.Trim(),
                            seq.ToString("00"));
                    dtbBarcode.Rows.Add(new string[] {
                        barcode,
                        "W/O: " + txtWorkOrderNo.Text.Trim(),
                        "Date: " + dtpWorkOrderDate.Value.ToString("dd/MM/yyyy HH:mm"),
                        "Q'ty: " + actual.ToString("N0"),
                        "Model: " + txtModel.Text.Trim(),
                        "P/N: " + txtPartNumber.Text.Trim(),
                        "Name: " + txtPartNameShort.Text.Trim()
                    });

                    //Table Inventory
                    Inventory inventory = new Inventory();
                    inventory.WorkOrderId = _id;
                    inventory.Barcode = barcode;
                    inventory.QuantityActual = actual;
                    inventory.QuantityRemain = actual;
                    _inventoryRepository.Save(inventory);
                }
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    //Print
                    rptBarcode rptBarcode = new rptBarcode();
                    rptBarcode.DataSource = dtbBarcode;
                    rptBarcode.PrinterName = GlobalConstants.printerName;
                    DevExpress.XtraReports.UI.ReportPrintTool reportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(rptBarcode);
                    reportPrintTool.AutoShowParametersPanel = false;
                    reportPrintTool.Print();
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("In thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("In thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("In thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}