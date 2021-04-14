namespace DongYang.View.Reports
{
    partial class frmTracingHistory
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
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Location = new System.Drawing.Point(5, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 40);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel (F4)";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(91, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Lọc (F5)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(904, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Location = new System.Drawing.Point(0, 50);
            this.dgvDuLieu.MainView = this.viewDuLieu;
            this.dgvDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1});
            this.dgvDuLieu.Size = new System.Drawing.Size(996, 418);
            this.dgvDuLieu.TabIndex = 1;
            this.dgvDuLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDuLieu});
            // 
            // viewDuLieu
            // 
            this.viewDuLieu.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.viewDuLieu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseForeColor = true;
            this.viewDuLieu.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viewDuLieu.Appearance.OddRow.Options.UseBackColor = true;
            this.viewDuLieu.ColumnPanelRowHeight = 40;
            this.viewDuLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Barcode,
            this.ScanDate,
            this.Action,
            this.ProductionStatus});
            this.viewDuLieu.DetailHeight = 284;
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 40;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.EnableAppearanceOddRow = true;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowDetailButtons = false;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 40;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceHeader.Options.UseFont = true;
            this.Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.Caption = "Id";
            this.Id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // Barcode
            // 
            this.Barcode.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Barcode.AppearanceCell.Options.UseFont = true;
            this.Barcode.AppearanceCell.Options.UseTextOptions = true;
            this.Barcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Barcode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Barcode.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Barcode.AppearanceHeader.Options.UseFont = true;
            this.Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Barcode.Caption = "Mã vạch sản phẩm";
            this.Barcode.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Barcode.FieldName = "Barcode";
            this.Barcode.MinWidth = 150;
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 0;
            this.Barcode.Width = 150;
            // 
            // ScanDate
            // 
            this.ScanDate.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScanDate.AppearanceCell.Options.UseFont = true;
            this.ScanDate.AppearanceCell.Options.UseTextOptions = true;
            this.ScanDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ScanDate.AppearanceHeader.Options.UseFont = true;
            this.ScanDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ScanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanDate.Caption = "Ngày sản xuất";
            this.ScanDate.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ScanDate.FieldName = "ScanDate";
            this.ScanDate.MaxWidth = 150;
            this.ScanDate.MinWidth = 150;
            this.ScanDate.Name = "ScanDate";
            this.ScanDate.Visible = true;
            this.ScanDate.VisibleIndex = 1;
            this.ScanDate.Width = 150;
            // 
            // Action
            // 
            this.Action.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Action.AppearanceCell.Options.UseFont = true;
            this.Action.AppearanceCell.Options.UseTextOptions = true;
            this.Action.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Action.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Action.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Action.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Action.AppearanceHeader.Options.UseFont = true;
            this.Action.AppearanceHeader.Options.UseTextOptions = true;
            this.Action.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Action.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Action.Caption = "Hành động";
            this.Action.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Action.FieldName = "Action";
            this.Action.MaxWidth = 150;
            this.Action.MinWidth = 150;
            this.Action.Name = "Action";
            this.Action.Visible = true;
            this.Action.VisibleIndex = 2;
            this.Action.Width = 150;
            // 
            // ProductionStatus
            // 
            this.ProductionStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductionStatus.AppearanceCell.Options.UseFont = true;
            this.ProductionStatus.AppearanceCell.Options.UseTextOptions = true;
            this.ProductionStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductionStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ProductionStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ProductionStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ProductionStatus.AppearanceHeader.Options.UseFont = true;
            this.ProductionStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductionStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductionStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ProductionStatus.Caption = "Kết quả";
            this.ProductionStatus.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ProductionStatus.FieldName = "ProductionStatus";
            this.ProductionStatus.MaxWidth = 150;
            this.ProductionStatus.MinWidth = 150;
            this.ProductionStatus.Name = "ProductionStatus";
            this.ProductionStatus.Visible = true;
            this.ProductionStatus.VisibleIndex = 3;
            this.ProductionStatus.Width = 150;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(996, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtpToDate);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.dtpFromDate);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(177, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(360, 40);
            this.panelControl2.TabIndex = 2;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(237, 7);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(115, 27);
            this.dtpToDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(181, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 15);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Đến ngày";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(60, 7);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(115, 27);
            this.dtpFromDate.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 15);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Từ ngày";
            // 
            // frmTracingHistory
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(996, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTracingHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu lịch sử sản xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTracingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Action;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn ScanDate;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}