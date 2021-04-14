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

namespace DongYang.View.Products
{
    public partial class frmProductsAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext;
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
        bool _quickAdd = false;

        public frmProductsAddEdit()
        {
            InitializeComponent();
        }

        public frmProductsAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmProductsAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmProductsAddEdit_Load(object sender, EventArgs e)
        {
            _projectDataContext = new ProjectDataContext();
            _productRepository = new ProductRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
        }

        private void Clear()
        {
            txtModel.Text = "";
            txtPartNumber.Text = "";
            txtPartName.Text = "";
            txtPartNameShort.Text = "";
            txtNote.Text = "";
            txtModel.Focus();
        }

        private void GetData()
        {
            //Get Data Table Product
            Product product = _productRepository.Get(_id);
            txtModel.Text = product.Model;
            txtPartNumber.Text = product.PartNumber;
            txtPartName.Text = product.PartName;
            txtPartNameShort.Text = product.PartNameShort;
            txtNote.Text = product.Note;
            chkUsing.Checked = (product.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtModel.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return false;
            }
            else if (txtPartNumber.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartNumber.Focus();
                return false;
            }
            else if (txtPartName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartName.Focus();
                return false;
            }
            else if (txtPartNameShort.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartNameShort.Focus();
                return false;
            }
            Product product = _productRepository.FirstOrDefault(_ => _.PartName.Equals(txtPartName.Text.Trim()));
            if (product != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtPartName.Text.Trim() != product.PartName)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Product
                Product product = new Product();
                product.Id = _id;
                product.Model = txtModel.Text.Trim();
                product.PartNumber = txtPartNumber.Text.Trim();
                product.PartName = txtPartName.Text.Trim();
                product.PartNameShort = txtPartNameShort.Text.Trim();
                product.Note = txtNote.Text.Trim();
                product.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _productRepository.Save(product);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = txtPartNumber.Text.Trim();
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                            Clear();
                        }
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

        private void chkUsing_CheckedChanged(object sender, EventArgs e)
        {
            chkNoUse.Checked = !chkUsing.Checked;
        }
    }
}