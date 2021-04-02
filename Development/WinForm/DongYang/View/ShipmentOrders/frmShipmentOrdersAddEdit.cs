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

namespace DongYang.View.ShipmentOrders
{
    public partial class frmShipmentOrdersAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext;
        ShipmentOrderRepository _shipmentOrderRepository;
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
        public frmShipmentOrdersAddEdit()
        {
            InitializeComponent();
        }

        public frmShipmentOrdersAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmShipmentOrdersAddEdit_Load(object sender, EventArgs e)
        {
            _projectDataContext = new ProjectDataContext();
            _shipmentOrderRepository = new ShipmentOrderRepository(_projectDataContext);
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
            cbbPartNumber.DataSource = _productRepository.GetData().OrderBy(_ => _.PartNumber).ToList();
            cbbPartNumber.SelectedIndex = 0;
        }

        private void cbbPartNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isLoadedCombobox && cbbPartNumber.SelectedValue != null && !String.IsNullOrEmpty(cbbPartNumber.Text.Trim()))
            {
                txtModel.Text = cbbPartNumber.SelectedValue.ToString().Split('|')[0];
                txtPartName.Text = cbbPartNumber.SelectedValue.ToString().Split('|')[1];
                txtPartNameShort.Text = cbbPartNumber.SelectedValue.ToString().Split('|')[2];
            }
        }

        private void Clear()
        {
            cbbPartNumber.SelectedIndex = -1;
            txtModel.Text = "";
            txtPartName.Text = "";
            txtPartNameShort.Text = "";
            txtQuantity.Value = 0;
            txtModel.Focus();
        }

        private void GetData()
        {
            //Get Data Table ShipmentOrder
            ShipmentOrder shipmentOrder = _shipmentOrderRepository.Get(_id);
            txtShipmentOrderNo.Text = shipmentOrder.ShipmentOrderNo;
            dtpShipmentOrderDate.Value = shipmentOrder.ShipmentOrderDate;
            cbbPartNumber.Text = shipmentOrder.PartNumber;
            txtModel.Text = shipmentOrder.Model;
            txtPartName.Text = shipmentOrder.PartName;
            txtPartNameShort.Text = shipmentOrder.PartNameShort;
            txtQuantity.Value = (decimal)shipmentOrder.Quantity;
        }

        private bool CheckData()
        {
            if (cbbPartNumber.SelectedValue == null || String.IsNullOrEmpty(cbbPartNumber.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbPartNumber.DroppedDown = true;
                return false;
            }
            else if (txtQuantity.Value == 0)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }
            ShipmentOrder shipmentOrder = _shipmentOrderRepository.FirstOrDefault(_ => _.ShipmentOrderNo.Equals(txtShipmentOrderNo.Text.Trim()));
            if (shipmentOrder != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtShipmentOrderNo.Text.Trim() != shipmentOrder.ShipmentOrderNo)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShipmentOrderNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table ShipmentOrder
                ShipmentOrder shipmentOrder = new ShipmentOrder();
                shipmentOrder.Id = _id;
                shipmentOrder.ShipmentOrderNo = txtShipmentOrderNo.Text.Trim();
                shipmentOrder.ShipmentOrderDate = dtpShipmentOrderDate.Value;
                shipmentOrder.PartNumber = cbbPartNumber.Text.Trim();
                shipmentOrder.Model = txtModel.Text.Trim();
                shipmentOrder.PartName = txtPartName.Text.Trim();
                shipmentOrder.PartNameShort = txtPartNameShort.Text.Trim();
                shipmentOrder.Quantity = (float)txtQuantity.Value;
                _shipmentOrderRepository.Save(shipmentOrder);
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
                cbbPartNumber.Text = (string)frm.Tag;
                _isLoadedCombobox = true;
                cbbPartNumber_SelectedValueChanged(null, null);
            }
        }
    }
}