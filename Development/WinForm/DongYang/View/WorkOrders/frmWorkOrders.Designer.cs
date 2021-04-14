namespace DongYang.View.WorkOrders
{
    partial class frmWorkOrders
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.WorkOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartNameShort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityPerCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrintBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnExcel.Location = new System.Drawing.Point(270, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 40);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel (F4)";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(356, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 4;
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
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(184, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa (F3)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(98, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa (F2)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm (F1)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.WorkOrderNo,
            this.WorkOrderDate,
            this.Model,
            this.PartNumber,
            this.PartName,
            this.PartNameShort,
            this.Quantity,
            this.QuantityPerCart,
            this.Status,
            this.PrintBarcode});
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
            this.viewDuLieu.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.viewDuLieu_RowCellClick);
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
            this.viewDuLieu.DoubleClick += new System.EventHandler(this.btnEdit_Click);
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
            // WorkOrderNo
            // 
            this.WorkOrderNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkOrderNo.AppearanceCell.Options.UseFont = true;
            this.WorkOrderNo.AppearanceCell.Options.UseTextOptions = true;
            this.WorkOrderNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrderNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WorkOrderNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WorkOrderNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WorkOrderNo.AppearanceHeader.Options.UseFont = true;
            this.WorkOrderNo.AppearanceHeader.Options.UseTextOptions = true;
            this.WorkOrderNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrderNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WorkOrderNo.Caption = "Mã lệnh sản xuất";
            this.WorkOrderNo.ColumnEdit = this.repositoryItemMemoEdit1;
            this.WorkOrderNo.FieldName = "WorkOrderNo";
            this.WorkOrderNo.MaxWidth = 100;
            this.WorkOrderNo.MinWidth = 100;
            this.WorkOrderNo.Name = "WorkOrderNo";
            this.WorkOrderNo.Visible = true;
            this.WorkOrderNo.VisibleIndex = 0;
            this.WorkOrderNo.Width = 100;
            // 
            // WorkOrderDate
            // 
            this.WorkOrderDate.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkOrderDate.AppearanceCell.Options.UseFont = true;
            this.WorkOrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.WorkOrderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrderDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WorkOrderDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WorkOrderDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WorkOrderDate.AppearanceHeader.Options.UseFont = true;
            this.WorkOrderDate.AppearanceHeader.Options.UseTextOptions = true;
            this.WorkOrderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrderDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.WorkOrderDate.Caption = "Ngày yêu cầu sản xuất";
            this.WorkOrderDate.ColumnEdit = this.repositoryItemMemoEdit1;
            this.WorkOrderDate.FieldName = "WorkOrderDate";
            this.WorkOrderDate.MaxWidth = 80;
            this.WorkOrderDate.MinWidth = 80;
            this.WorkOrderDate.Name = "WorkOrderDate";
            this.WorkOrderDate.Visible = true;
            this.WorkOrderDate.VisibleIndex = 1;
            this.WorkOrderDate.Width = 80;
            // 
            // Model
            // 
            this.Model.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Model.AppearanceCell.Options.UseFont = true;
            this.Model.AppearanceCell.Options.UseTextOptions = true;
            this.Model.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Model.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Model.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Model.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Model.AppearanceHeader.Options.UseFont = true;
            this.Model.AppearanceHeader.Options.UseTextOptions = true;
            this.Model.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Model.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Model.Caption = "Model";
            this.Model.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Model.FieldName = "Model";
            this.Model.MaxWidth = 150;
            this.Model.MinWidth = 150;
            this.Model.Name = "Model";
            this.Model.Visible = true;
            this.Model.VisibleIndex = 3;
            this.Model.Width = 150;
            // 
            // PartNumber
            // 
            this.PartNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PartNumber.AppearanceCell.Options.UseFont = true;
            this.PartNumber.AppearanceCell.Options.UseTextOptions = true;
            this.PartNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PartNumber.AppearanceHeader.Options.UseFont = true;
            this.PartNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber.Caption = "Mã sản phẩm";
            this.PartNumber.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNumber.FieldName = "PartNumber";
            this.PartNumber.MaxWidth = 150;
            this.PartNumber.MinWidth = 150;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Visible = true;
            this.PartNumber.VisibleIndex = 2;
            this.PartNumber.Width = 150;
            // 
            // PartName
            // 
            this.PartName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PartName.AppearanceCell.Options.UseFont = true;
            this.PartName.AppearanceCell.Options.UseTextOptions = true;
            this.PartName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PartName.AppearanceHeader.Options.UseFont = true;
            this.PartName.AppearanceHeader.Options.UseTextOptions = true;
            this.PartName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartName.Caption = "Tên sản phẩm (Dài)";
            this.PartName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartName.FieldName = "PartName";
            this.PartName.MinWidth = 150;
            this.PartName.Name = "PartName";
            this.PartName.Visible = true;
            this.PartName.VisibleIndex = 4;
            this.PartName.Width = 150;
            // 
            // PartNameShort
            // 
            this.PartNameShort.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PartNameShort.AppearanceCell.Options.UseFont = true;
            this.PartNameShort.AppearanceCell.Options.UseTextOptions = true;
            this.PartNameShort.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNameShort.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNameShort.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNameShort.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PartNameShort.AppearanceHeader.Options.UseFont = true;
            this.PartNameShort.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNameShort.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNameShort.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNameShort.Caption = "Tên sản phẩm (Ngắn)";
            this.PartNameShort.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNameShort.FieldName = "PartNameShort";
            this.PartNameShort.MaxWidth = 150;
            this.PartNameShort.MinWidth = 150;
            this.PartNameShort.Name = "PartNameShort";
            this.PartNameShort.Visible = true;
            this.PartNameShort.VisibleIndex = 5;
            this.PartNameShort.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Quantity.AppearanceCell.Options.UseFont = true;
            this.Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Quantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Quantity.Caption = "Số lượng y/c sản xuất";
            this.Quantity.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MaxWidth = 80;
            this.Quantity.MinWidth = 80;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 6;
            this.Quantity.Width = 80;
            // 
            // QuantityPerCart
            // 
            this.QuantityPerCart.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityPerCart.AppearanceCell.Options.UseFont = true;
            this.QuantityPerCart.AppearanceCell.Options.UseTextOptions = true;
            this.QuantityPerCart.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityPerCart.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QuantityPerCart.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityPerCart.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.QuantityPerCart.AppearanceHeader.Options.UseFont = true;
            this.QuantityPerCart.AppearanceHeader.Options.UseTextOptions = true;
            this.QuantityPerCart.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantityPerCart.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.QuantityPerCart.Caption = "Số lượng /1 xe";
            this.QuantityPerCart.ColumnEdit = this.repositoryItemMemoEdit1;
            this.QuantityPerCart.FieldName = "QuantityPerCart";
            this.QuantityPerCart.MaxWidth = 70;
            this.QuantityPerCart.MinWidth = 70;
            this.QuantityPerCart.Name = "QuantityPerCart";
            this.QuantityPerCart.Visible = true;
            this.QuantityPerCart.VisibleIndex = 7;
            this.QuantityPerCart.Width = 70;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Status.AppearanceCell.Options.UseFont = true;
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Status.AppearanceHeader.Options.UseFont = true;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MaxWidth = 75;
            this.Status.MinWidth = 75;
            this.Status.Name = "Status";
            // 
            // PrintBarcode
            // 
            this.PrintBarcode.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PrintBarcode.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.PrintBarcode.AppearanceCell.Options.UseFont = true;
            this.PrintBarcode.AppearanceCell.Options.UseForeColor = true;
            this.PrintBarcode.AppearanceCell.Options.UseTextOptions = true;
            this.PrintBarcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PrintBarcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PrintBarcode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PrintBarcode.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PrintBarcode.AppearanceHeader.Options.UseFont = true;
            this.PrintBarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.PrintBarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PrintBarcode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PrintBarcode.Caption = "In mã vạch";
            this.PrintBarcode.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PrintBarcode.FieldName = "PrintBarcode";
            this.PrintBarcode.MaxWidth = 60;
            this.PrintBarcode.MinWidth = 60;
            this.PrintBarcode.Name = "PrintBarcode";
            this.PrintBarcode.Visible = true;
            this.PrintBarcode.VisibleIndex = 8;
            this.PrintBarcode.Width = 60;
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
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnAdd);
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
            this.panelControl2.Location = new System.Drawing.Point(442, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(360, 40);
            this.panelControl2.TabIndex = 5;
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
            // frmWorkOrders
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(996, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWorkOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lệnh sản xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWorkOrders_Load);
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

        //private System.Windows.Forms.Panel radPanel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn PartName;
        private DevExpress.XtraGrid.Columns.GridColumn PartNameShort;
        private DevExpress.XtraGrid.Columns.GridColumn WorkOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn WorkOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityPerCart;
        private DevExpress.XtraGrid.Columns.GridColumn PrintBarcode;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}