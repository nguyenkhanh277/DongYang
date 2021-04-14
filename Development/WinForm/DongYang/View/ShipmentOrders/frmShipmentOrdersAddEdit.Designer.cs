namespace DongYang.View.ShipmentOrders
{
    partial class frmShipmentOrdersAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipmentOrdersAddEdit));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnProductAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.dtpShipmentOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.txtPartNameShort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtShipmentOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameShort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipmentOrderNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(265, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(242)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(179, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu (F1)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 192);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Model";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ngày yêu cầu xuất hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 375);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(147, 15);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Số lượng yêu cầu xuất hàng";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProductAdd.Appearance.Options.UseFont = true;
            this.btnProductAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProductAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProductAdd.ImageOptions.SvgImage")));
            this.btnProductAdd.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 25);
            this.btnProductAdd.Location = new System.Drawing.Point(315, 155);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(30, 30);
            this.btnProductAdd.TabIndex = 6;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // cbbProduct
            // 
            this.cbbProduct.DisplayMember = "PartNumber";
            this.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(45, 156);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(266, 29);
            this.cbbProduct.TabIndex = 2;
            this.cbbProduct.ValueMember = "Datas";
            this.cbbProduct.SelectedValueChanged += new System.EventHandler(this.cbbProduct_SelectedValueChanged);
            // 
            // dtpShipmentOrderDate
            // 
            this.dtpShipmentOrderDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpShipmentOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpShipmentOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShipmentOrderDate.Location = new System.Drawing.Point(45, 98);
            this.dtpShipmentOrderDate.Name = "dtpShipmentOrderDate";
            this.dtpShipmentOrderDate.Size = new System.Drawing.Size(300, 29);
            this.dtpShipmentOrderDate.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.EditValue = "";
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(45, 215);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.Properties.Appearance.Options.UseFont = true;
            this.txtModel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtModel.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtModel.Properties.AutoHeight = false;
            this.txtModel.Size = new System.Drawing.Size(300, 30);
            this.txtModel.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 134);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 15);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Mã sản phẩm";
            // 
            // txtPartName
            // 
            this.txtPartName.EditValue = "";
            this.txtPartName.Enabled = false;
            this.txtPartName.Location = new System.Drawing.Point(45, 276);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartName.Properties.Appearance.Options.UseFont = true;
            this.txtPartName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartName.Properties.AutoHeight = false;
            this.txtPartName.Size = new System.Drawing.Size(300, 30);
            this.txtPartName.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 253);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 15);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Tên sản phẩm (Dài)";
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQuantity.Location = new System.Drawing.Point(45, 397);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Properties.DisplayFormat.FormatString = "N0";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.EditFormat.FormatString = "N0";
            this.txtQuantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.IsFloatValue = false;
            this.txtQuantity.Properties.Mask.EditMask = "N0";
            this.txtQuantity.Size = new System.Drawing.Size(300, 28);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtPartNameShort
            // 
            this.txtPartNameShort.EditValue = "";
            this.txtPartNameShort.Enabled = false;
            this.txtPartNameShort.Location = new System.Drawing.Point(45, 337);
            this.txtPartNameShort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartNameShort.Name = "txtPartNameShort";
            this.txtPartNameShort.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartNameShort.Properties.Appearance.Options.UseFont = true;
            this.txtPartNameShort.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartNameShort.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartNameShort.Properties.AutoHeight = false;
            this.txtPartNameShort.Size = new System.Drawing.Size(300, 30);
            this.txtPartNameShort.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(45, 314);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 15);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Tên sản phẩm (Ngắn)";
            // 
            // txtShipmentOrderNo
            // 
            this.txtShipmentOrderNo.EditValue = "";
            this.txtShipmentOrderNo.Location = new System.Drawing.Point(45, 38);
            this.txtShipmentOrderNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShipmentOrderNo.Name = "txtShipmentOrderNo";
            this.txtShipmentOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShipmentOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtShipmentOrderNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtShipmentOrderNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtShipmentOrderNo.Properties.AutoHeight = false;
            this.txtShipmentOrderNo.Size = new System.Drawing.Size(300, 30);
            this.txtShipmentOrderNo.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(45, 15);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(71, 15);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Mã đơn hàng";
            // 
            // frmShipmentOrdersAddEdit
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(390, 488);
            this.Controls.Add(this.txtShipmentOrderNo);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtPartNameShort);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbbProduct);
            this.Controls.Add(this.dtpShipmentOrderDate);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShipmentOrdersAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.frmShipmentOrdersAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameShort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipmentOrderNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnProductAdd;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.DateTimePicker dtpShipmentOrderDate;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPartName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtPartNameShort;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtShipmentOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}