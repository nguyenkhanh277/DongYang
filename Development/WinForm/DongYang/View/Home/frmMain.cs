using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DongYang.Core;
using DongYang.Core.Helper;
using DongYang.Persistence;
using DongYang.Persistence.Repositories;
using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using System.Threading;

namespace DongYang.View.Home
{
    public partial class frmMain : RibbonForm
    {
        ProjectDataContext _projectDataContext;
        UserRepository _userRepository;
        //Thread thread;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        #region SkinGallery
        void InitSkinGallery()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void rgbiSkins_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {

            Properties.Settings.Default.Theme = e.Item.Value.ToString();
            Properties.Settings.Default.Save();
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _projectDataContext = new ProjectDataContext();
            _userRepository = new UserRepository(_projectDataContext);
            this.Icon = Properties.Resources.icon;
            this.Text = LanguageTranslate.ChangeLanguageText(this.Text);
            Translate();
            Permission();
            ribbonControl1.SelectPage(rbpChucNang);
            //thread = new Thread(() =>
            //{
            //    this.BeginInvoke(new MethodInvoker(() =>
            //    {
            //        Alarm();
            //        try
            //        {
            //            thread.Abort();
            //        }
            //        catch { }
            //    }));
            //});
            //thread.IsBackground = true;
            //thread.Start();
        }

        private void Alarm()
        {
            int count = 0;
            if (count > 0)
            {
                alertControl.Show(this, "Thông báo", "Bạn có " + count + " kế hoạch cần xử lý", string.Empty);
            }
        }

        private void alertControl_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        private void Translate()
        {
            rbpHeThong.Text = LanguageTranslate.ChangeLanguageText(rbpHeThong.Text);
            rbpDanhMuc.Text = LanguageTranslate.ChangeLanguageText(rbpDanhMuc.Text);
            rbpChucNang.Text = LanguageTranslate.ChangeLanguageText(rbpChucNang.Text);
            rbpBaoCao.Text = LanguageTranslate.ChangeLanguageText(rbpBaoCao.Text);

            btnUsers.Caption = LanguageTranslate.ChangeLanguageText(btnUsers.Caption);
            btnChangePassword.Caption = LanguageTranslate.ChangeLanguageText(btnChangePassword.Caption);
            btnLanguageLibrary.Caption = LanguageTranslate.ChangeLanguageText(btnLanguageLibrary.Caption);
            btnSetting.Caption = LanguageTranslate.ChangeLanguageText(btnSetting.Caption);

            txtUser.Caption = LanguageTranslate.ChangeLanguageText("Tài khoản") + ": " + GlobalConstants.username + "  |  " + LanguageTranslate.ChangeLanguageText("Tên đầy đủ") + ": " + GlobalConstants.fullName;
        }

        private void Permission()
        {
            btnUsers.Enabled = _userRepository.CheckPermission(GlobalConstants.username, GlobalConstants.AuthorityGroupValue.Admin);
        }

        private XtraForm CheckExist(Type fType)
        {
            foreach (XtraForm f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Users.frmUsers));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Users.frmUsers f = new Users.frmUsers();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnLanguageLibrary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(LanguageLibrarys.frmLanguageLibrary));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                LanguageLibrarys.frmLanguageLibrary f = new LanguageLibrarys.frmLanguageLibrary();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }

        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Products.frmProducts));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Products.frmProducts f = new Products.frmProducts();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnWorkOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(WorkOrders.frmWorkOrders));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                WorkOrders.frmWorkOrders f = new WorkOrders.frmWorkOrders();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPrintBarocde_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnMonitoring_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnShipmentOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(ShipmentOrders.frmShipmentOrders));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                ShipmentOrders.frmShipmentOrders f = new ShipmentOrders.frmShipmentOrders();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnExport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnReportWorkOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Reports.frmReportWorkOrders));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Reports.frmReportWorkOrders f = new Reports.frmReportWorkOrders();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnReportPurchaseOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Reports.frmReportShipmentOrders));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Reports.frmReportShipmentOrders f = new Reports.frmReportShipmentOrders();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTracingHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Reports.frmTracingHistory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Reports.frmTracingHistory f = new Reports.frmTracingHistory();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Inventorys.frmInventorys));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Inventorys.frmInventorys f = new Inventorys.frmInventorys();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
