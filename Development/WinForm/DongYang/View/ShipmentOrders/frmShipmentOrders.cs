using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DongYang.Persistence;
using DongYang.Core;
using DongYang.Persistence.Repositories;
using DongYang.Core.Helper;

namespace DongYang.View.ShipmentOrders
{
    public partial class frmShipmentOrders : XtraForm
    {
        ProjectDataContext _projectDataContext;
        ShipmentOrderRepository _shipmentOrderRepository;

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
                btnAdd_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnEdit_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDelete_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnExcel_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmShipmentOrders()
        {
            InitializeComponent();
        }

        private void frmShipmentOrders_Load(object sender, EventArgs e)
        {
            _projectDataContext = new ProjectDataContext();
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            Search();
        }

        private void Search()
        {
            _projectDataContext = new ProjectDataContext();
            _shipmentOrderRepository = new ShipmentOrderRepository(_projectDataContext);
            DateTime fromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd 00:00:00"));
            DateTime toDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd 23:59:59"));
            dgvDuLieu.DataSource = _shipmentOrderRepository.GetAll().Where(_ => _.ShipmentOrderDate >= fromDate && _.ShipmentOrderDate <= toDate).OrderBy(_ => _.ShipmentOrderDate).ThenBy(_ => _.PartNumber);
            Control();
        }

        private void Control()
        {
            btnEdit.Enabled = btnDelete.Enabled = btnExcel.Enabled = (viewDuLieu.RowCount > 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmShipmentOrdersAddEdit frm = new frmShipmentOrdersAddEdit();
            frm.ShowDialog();
            Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (viewDuLieu.RowCount > 0 && viewDuLieu.FocusedRowHandle >= 0)
            {
                frmShipmentOrdersAddEdit frm = new frmShipmentOrdersAddEdit(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int index = viewDuLieu.FocusedRowHandle;
                    Search();
                    try
                    {
                        viewDuLieu.FocusedRowHandle = index;
                    }
                    catch { }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (viewDuLieu.RowCount > 0 && viewDuLieu.FocusedRowHandle >= 0 && XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Bạn có muốn xóa thông tin này?"), LanguageTranslate.ChangeLanguageText("Xác nhận"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _shipmentOrderRepository.UpdateStatus(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString(), GlobalConstants.StatusValue.NoUse);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    int index = viewDuLieu.FocusedRowHandle;
                    Search();
                    try
                    {
                        viewDuLieu.FocusedRowHandle = index - 1;
                    }
                    catch { }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Xóa thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            GeneralHelper.ExportExcel(dgvDuLieu);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewDuLieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (viewDuLieu.RowCount > 0 && viewDuLieu.FocusedRowHandle >= 0)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    Clipboard.SetText(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, viewDuLieu.FocusedColumn.Name).ToString());
                    e.Handled = true;
                }
            }
        }

        private void viewDuLieu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void viewDuLieu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view.GetRowCellValue(e.RowHandle, "Status").ToString() == "NoUse")
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Strikeout);
                }
            }
        }
    }
}