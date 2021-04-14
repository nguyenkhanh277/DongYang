namespace DongYang.View.Reports
{
    partial class frmReportShipmentOrders
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
            this.WorkOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.PartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartNameShort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityRemain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(898, 5);
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
            this.dgvDuLieu.Size = new System.Drawing.Size(990, 418);
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
            this.viewDuLieu.ColumnPanelRowHeight = 45;
            this.viewDuLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WorkOrderDate,
            this.PartNumber,
            this.Model,
            this.PartName,
            this.PartNameShort,
            this.QuantityOrder,
            this.QuantityExport,
            this.QuantityRemain});
            this.viewDuLieu.DetailHeight = 284;
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 40;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowFooter = true;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 40;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
            // 
            // WorkOrderDate
            // 
            this.WorkOrderDate.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WorkOrderDate.AppearanceCell.Options.UseFont = true;
            this.WorkOrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.WorkOrderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrderDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WorkOrderDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WorkOrderDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WorkOrderDate.AppearanceHeader.Options.UseFont = true;
            this.WorkOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.WorkOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrderDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WorkOrderDate.Caption = "Ngày";
            this.WorkOrderDate.ColumnEdit = this.repositoryItemMemoEdit1;
            this.WorkOrderDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.WorkOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.WorkOrderDate.FieldName = "WorkOrderDate";
            this.WorkOrderDate.MaxWidth = 100;
            this.WorkOrderDate.MinWidth = 100;
            this.WorkOrderDate.Name = "WorkOrderDate";
            this.WorkOrderDate.Visible = true;
            this.WorkOrderDate.VisibleIndex = 0;
            this.WorkOrderDate.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // PartNumber
            // 
            this.PartNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PartNumber.AppearanceCell.Options.UseFont = true;
            this.PartNumber.AppearanceCell.Options.UseTextOptions = true;
            this.PartNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.PartNumber.AppearanceHeader.Options.UseFont = true;
            this.PartNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber.Caption = "Mã sản phẩm";
            this.PartNumber.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNumber.FieldName = "PartNumber";
            this.PartNumber.MaxWidth = 100;
            this.PartNumber.MinWidth = 100;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Visible = true;
            this.PartNumber.VisibleIndex = 1;
            this.PartNumber.Width = 100;
            // 
            // Model
            // 
            this.Model.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Model.AppearanceCell.Options.UseFont = true;
            this.Model.AppearanceCell.Options.UseTextOptions = true;
            this.Model.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Model.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Model.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Model.AppearanceHeader.Options.UseFont = true;
            this.Model.AppearanceHeader.Options.UseTextOptions = true;
            this.Model.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Model.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Model.Caption = "Model";
            this.Model.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Model.FieldName = "Model";
            this.Model.MaxWidth = 100;
            this.Model.MinWidth = 100;
            this.Model.Name = "Model";
            this.Model.Visible = true;
            this.Model.VisibleIndex = 2;
            this.Model.Width = 100;
            // 
            // PartName
            // 
            this.PartName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PartName.AppearanceCell.Options.UseFont = true;
            this.PartName.AppearanceCell.Options.UseTextOptions = true;
            this.PartName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.PartName.AppearanceHeader.Options.UseFont = true;
            this.PartName.AppearanceHeader.Options.UseTextOptions = true;
            this.PartName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartName.Caption = "Tên sản phẩm (Dài)";
            this.PartName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartName.FieldName = "PartName";
            this.PartName.MaxWidth = 200;
            this.PartName.MinWidth = 200;
            this.PartName.Name = "PartName";
            this.PartName.Visible = true;
            this.PartName.VisibleIndex = 3;
            this.PartName.Width = 200;
            // 
            // PartNameShort
            // 
            this.PartNameShort.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PartNameShort.AppearanceCell.Options.UseFont = true;
            this.PartNameShort.AppearanceCell.Options.UseTextOptions = true;
            this.PartNameShort.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNameShort.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNameShort.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.PartNameShort.AppearanceHeader.Options.UseFont = true;
            this.PartNameShort.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNameShort.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNameShort.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNameShort.Caption = "Tên sản phẩm (Ngắn)";
            this.PartNameShort.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNameShort.FieldName = "PartNameShort";
            this.PartNameShort.MinWidth = 100;
            this.PartNameShort.Name = "PartNameShort";
            this.PartNameShort.Visible = true;
            this.PartNameShort.VisibleIndex = 4;
            this.PartNameShort.Width = 188;
            // 
            // QuantityOrder
            // 
            this.QuantityOrder.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.QuantityOrder.AppearanceCell.Options.UseFont = true;
            this.QuantityOrder.AppearanceCell.Options.UseTextOptions = true;
            this.QuantityOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityOrder.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QuantityOrder.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityOrder.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.QuantityOrder.AppearanceHeader.Options.UseFont = true;
            this.QuantityOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.QuantityOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityOrder.Caption = "Số lượng yêu cầu";
            this.QuantityOrder.ColumnEdit = this.repositoryItemMemoEdit1;
            this.QuantityOrder.DisplayFormat.FormatString = "N0";
            this.QuantityOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.QuantityOrder.FieldName = "QuantityOrder";
            this.QuantityOrder.MaxWidth = 80;
            this.QuantityOrder.MinWidth = 80;
            this.QuantityOrder.Name = "QuantityOrder";
            this.QuantityOrder.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityPlan", "{0:0.##}")});
            this.QuantityOrder.Visible = true;
            this.QuantityOrder.VisibleIndex = 5;
            this.QuantityOrder.Width = 80;
            // 
            // QuantityExport
            // 
            this.QuantityExport.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.QuantityExport.AppearanceCell.Options.UseFont = true;
            this.QuantityExport.AppearanceCell.Options.UseTextOptions = true;
            this.QuantityExport.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityExport.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QuantityExport.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityExport.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.QuantityExport.AppearanceHeader.Options.UseFont = true;
            this.QuantityExport.AppearanceHeader.Options.UseTextOptions = true;
            this.QuantityExport.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityExport.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityExport.Caption = "Số lượng xuất kho";
            this.QuantityExport.ColumnEdit = this.repositoryItemMemoEdit1;
            this.QuantityExport.DisplayFormat.FormatString = "N0";
            this.QuantityExport.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.QuantityExport.FieldName = "QuantityExport";
            this.QuantityExport.MaxWidth = 80;
            this.QuantityExport.MinWidth = 80;
            this.QuantityExport.Name = "QuantityExport";
            this.QuantityExport.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityScan", "{0:0.##}")});
            this.QuantityExport.Visible = true;
            this.QuantityExport.VisibleIndex = 6;
            this.QuantityExport.Width = 80;
            // 
            // QuantityRemain
            // 
            this.QuantityRemain.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.QuantityRemain.AppearanceCell.Options.UseFont = true;
            this.QuantityRemain.AppearanceCell.Options.UseTextOptions = true;
            this.QuantityRemain.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityRemain.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QuantityRemain.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityRemain.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.QuantityRemain.AppearanceHeader.Options.UseFont = true;
            this.QuantityRemain.AppearanceHeader.Options.UseTextOptions = true;
            this.QuantityRemain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityRemain.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityRemain.Caption = "Số lượng tồn kho";
            this.QuantityRemain.ColumnEdit = this.repositoryItemMemoEdit1;
            this.QuantityRemain.DisplayFormat.FormatString = "N0";
            this.QuantityRemain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.QuantityRemain.FieldName = "QuantityRemain";
            this.QuantityRemain.MaxWidth = 80;
            this.QuantityRemain.MinWidth = 80;
            this.QuantityRemain.Name = "QuantityRemain";
            this.QuantityRemain.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOK", "{0:0.##}")});
            this.QuantityRemain.Visible = true;
            this.QuantityRemain.VisibleIndex = 7;
            this.QuantityRemain.Width = 80;
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
            // pnControl
            // 
            this.pnControl.Controls.Add(this.panelControl2);
            this.pnControl.Controls.Add(this.btnExcel);
            this.pnControl.Controls.Add(this.btnRefresh);
            this.pnControl.Controls.Add(this.btnClose);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(990, 50);
            this.pnControl.TabIndex = 0;
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
            // frmReportShipmentOrders
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(990, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.pnControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReportShipmentOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp báo cáo đơn hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportShipmentOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
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
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn WorkOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn PartNameShort;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityOrder;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityExport;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityRemain;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private DevExpress.XtraGrid.Columns.GridColumn PartName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}