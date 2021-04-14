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
    public partial class frmWorkOrdersAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext;
        WorkOrderRepository _workOrderRepository;
        ProductRepository _productRepository;

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
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string _id = "";
        bool _isLoadedCombobox = false;
        public frmWorkOrdersAddEdit()
        {
            InitializeComponent();
        }

        public frmWorkOrdersAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmWorkOrdersAddEdit_Load(object sender, EventArgs e)
        {
            _projectDataContext = new ProjectDataContext();
            _workOrderRepository = new WorkOrderRepository(_projectDataContext);
            _productRepository = new ProductRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LoadProductData();
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
            _isLoadedCombobox = true;
        }

        private void LoadProductData()
        {
            cbbProduct.DataSource = _productRepository.GetData().OrderBy(_ => _.PartNumber).ToList();
            cbbProduct.SelectedIndex = 0;
        }

        private void cbbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadedCombobox && cbbProduct.SelectedValue != null && !String.IsNullOrEmpty(cbbProduct.Text.Trim()))
            {
                txtModel.Text = cbbProduct.SelectedValue.ToString().Split('|')[0];
                txtPartName.Text = cbbProduct.SelectedValue.ToString().Split('|')[1];
                txtPartNameShort.Text = cbbProduct.SelectedValue.ToString().Split('|')[2];
            }
        }

        private void Clear()
        {
            cbbProduct.SelectedIndex = -1;
            txtModel.Text = "";
            txtPartName.Text = "";
            txtPartNameShort.Text = "";
            txtQuantity.Value = 0;
            txtModel.Focus();
        }

        private void GetData()
        {
            //Get Data Table WorkOrder
            WorkOrder workOrder = _workOrderRepository.Get(_id);
            txtWorkOrderNo.Text = workOrder.WorkOrderNo;
            dtpWorkOrderDate.Value = workOrder.WorkOrderDate;
            cbbProduct.Text = workOrder.PartNumber;
            txtModel.Text = workOrder.Model;
            txtPartName.Text = workOrder.PartName;
            txtPartNameShort.Text = workOrder.PartNameShort;
            txtQuantity.Value = (decimal)workOrder.Quantity;
        }

        private bool CheckData()
        {
            if (cbbProduct.SelectedValue == null || String.IsNullOrEmpty(cbbProduct.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbProduct.DroppedDown = true;
                return false;
            }
            else if (txtQuantity.Value == 0)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }
            WorkOrder workOrder = _workOrderRepository.FirstOrDefault(_ => _.WorkOrderNo.Equals(txtWorkOrderNo.Text.Trim()));
            if (workOrder != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtWorkOrderNo.Text.Trim() != workOrder.WorkOrderNo)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWorkOrderNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table WorkOrder
                WorkOrder workOrder = new WorkOrder();
                workOrder.Id = _id;
                workOrder.WorkOrderNo = txtWorkOrderNo.Text.Trim();
                workOrder.WorkOrderDate = dtpWorkOrderDate.Value;
                workOrder.PartNumber = cbbProduct.Text.Trim();
                workOrder.Model = txtModel.Text.Trim();
                workOrder.PartName = txtPartName.Text.Trim();
                workOrder.PartNameShort = txtPartNameShort.Text.Trim();
                workOrder.Quantity = (float)txtQuantity.Value;
                _workOrderRepository.Save(workOrder);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                        Clear();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Products.frmProductsAddEdit frm = new Products.frmProductsAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                _isLoadedCombobox = false;
                LoadProductData();
                cbbProduct.SelectedValue = (string)frm.Tag;
                _isLoadedCombobox = true;
                cbbProduct_SelectedValueChanged(null, null);
            }
        }
    }
}