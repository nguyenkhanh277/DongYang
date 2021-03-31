using DevExpress.XtraBars;

namespace DongYang.View.Home
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.txtUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnLanguageLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnTracingHistory = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportPurchaseOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnPurchaseOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonitoring = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintBarocde = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barStaticItem1);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnUsers,
            this.btnChangePassword,
            this.txtUser,
            this.btnLanguageLibrary,
            this.rgbiSkins,
            this.btnWorkOrder,
            this.btnProduct,
            this.btnSetting,
            this.btnTracingHistory,
            this.btnReportWorkOrder,
            this.btnReportPurchaseOrder,
            this.btnPurchaseOrder,
            this.btnExport,
            this.btnMonitoring,
            this.btnPrintBarocde});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 63;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.txtUser);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpDanhMuc,
            this.rbpChucNang,
            this.rbpBaoCao});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1014, 143);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Phone: 08 8822 2329 - Email: contact@datatech.vn";
            this.barStaticItem1.Id = 42;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Quản lý người dùng";
            this.btnUsers.Id = 11;
            this.btnUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUsers.ImageOptions.SvgImage")));
            this.btnUsers.LargeWidth = 100;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 12;
            this.btnChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChangePassword.ImageOptions.SvgImage")));
            this.btnChangePassword.LargeWidth = 100;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // txtUser
            // 
            this.txtUser.Caption = "     ";
            this.txtUser.Id = 18;
            this.txtUser.Name = "txtUser";
            // 
            // btnLanguageLibrary
            // 
            this.btnLanguageLibrary.Caption = "Ngôn ngữ";
            this.btnLanguageLibrary.Id = 19;
            this.btnLanguageLibrary.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLanguageLibrary.ImageOptions.SvgImage")));
            this.btnLanguageLibrary.LargeWidth = 100;
            this.btnLanguageLibrary.Name = "btnLanguageLibrary";
            this.btnLanguageLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLanguageLibrary_ItemClick);
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Id = 13;
            this.rgbiSkins.Name = "rgbiSkins";
            this.rgbiSkins.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiSkins_GalleryItemClick);
            // 
            // btnWorkOrder
            // 
            this.btnWorkOrder.Caption = "Lệnh sản xuất";
            this.btnWorkOrder.Id = 26;
            this.btnWorkOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWorkOrder.ImageOptions.SvgImage")));
            this.btnWorkOrder.LargeWidth = 100;
            this.btnWorkOrder.Name = "btnWorkOrder";
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Sản phẩm";
            this.btnProduct.Id = 34;
            this.btnProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProduct.ImageOptions.SvgImage")));
            this.btnProduct.LargeWidth = 100;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "Cấu hình";
            this.btnSetting.Id = 41;
            this.btnSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSetting.ImageOptions.SvgImage")));
            this.btnSetting.LargeWidth = 100;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // btnTracingHistory
            // 
            this.btnTracingHistory.Caption = "Tra cứu lịch sử sản xuất";
            this.btnTracingHistory.Id = 49;
            this.btnTracingHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTracingHistory.ImageOptions.SvgImage")));
            this.btnTracingHistory.LargeWidth = 100;
            this.btnTracingHistory.Name = "btnTracingHistory";
            // 
            // btnReportWorkOrder
            // 
            this.btnReportWorkOrder.Caption = "Tổng hợp kế hoạch sản xuất";
            this.btnReportWorkOrder.Id = 50;
            this.btnReportWorkOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReportWorkOrder.ImageOptions.SvgImage")));
            this.btnReportWorkOrder.LargeWidth = 100;
            this.btnReportWorkOrder.Name = "btnReportWorkOrder";
            // 
            // btnReportPurchaseOrder
            // 
            this.btnReportPurchaseOrder.Caption = "Tổng hợp báo cáo đơn hàng";
            this.btnReportPurchaseOrder.Id = 51;
            this.btnReportPurchaseOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReportPurchaseOrder.ImageOptions.SvgImage")));
            this.btnReportPurchaseOrder.LargeWidth = 100;
            this.btnReportPurchaseOrder.Name = "btnReportPurchaseOrder";
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Caption = "Đơn hàng";
            this.btnPurchaseOrder.Id = 56;
            this.btnPurchaseOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPurchaseOrder.ImageOptions.SvgImage")));
            this.btnPurchaseOrder.LargeWidth = 100;
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Xuất hàng";
            this.btnExport.Id = 60;
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.LargeWidth = 100;
            this.btnExport.Name = "btnExport";
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Caption = "Màn hình theo dõi sản xuất";
            this.btnMonitoring.Id = 61;
            this.btnMonitoring.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMonitoring.ImageOptions.SvgImage")));
            this.btnMonitoring.LargeWidth = 100;
            this.btnMonitoring.Name = "btnMonitoring";
            // 
            // btnPrintBarocde
            // 
            this.btnPrintBarocde.Caption = "In mã vạch";
            this.btnPrintBarocde.Id = 62;
            this.btnPrintBarocde.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintBarocde.ImageOptions.SvgImage")));
            this.btnPrintBarocde.LargeWidth = 100;
            this.btnPrintBarocde.Name = "btnPrintBarocde";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLanguageLibrary);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.rgbiSkins);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpChucNang
            // 
            this.rbpChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpChucNang.Name = "rbpChucNang";
            this.rbpChucNang.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnWorkOrder);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrintBarocde);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMonitoring);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPurchaseOrder);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnExport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportWorkOrder);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportPurchaseOrder);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTracingHistory);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // alertControl
            // 
            this.alertControl.AllowHotTrack = false;
            this.alertControl.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.alertControl.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.alertControl.AppearanceCaption.Options.UseFont = true;
            this.alertControl.AppearanceCaption.Options.UseForeColor = true;
            this.alertControl.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.alertControl.AppearanceText.ForeColor = System.Drawing.Color.Red;
            this.alertControl.AppearanceText.Options.UseFont = true;
            this.alertControl.AppearanceText.Options.UseForeColor = true;
            this.alertControl.AppearanceText.Options.UseTextOptions = true;
            this.alertControl.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alertControl.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.alertControl.AutoHeight = true;
            this.alertControl.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.alertControl_BeforeFormShow);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 379);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chương trình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem btnUsers;
        private BarButtonItem btnChangePassword;
        private BarStaticItem txtUser;
        private BarButtonItem btnLanguageLibrary;
        private RibbonGalleryBarItem rgbiSkins;
        private BarButtonItem btnWorkOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem btnProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private BarButtonItem btnSetting;
        private BarStaticItem barStaticItem1;
        private BarButtonItem btnTracingHistory;
        private BarButtonItem btnReportWorkOrder;
        private BarButtonItem btnReportPurchaseOrder;
        private BarButtonItem btnPurchaseOrder;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        private BarButtonItem btnMonitoring;
        private BarButtonItem btnPrintBarocde;
        private BarButtonItem btnExport;
    }
}

