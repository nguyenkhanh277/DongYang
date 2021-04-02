namespace DongYang.View.WorkOrders
{
    partial class frmPrintBarcodes
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.txtPartNameShort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtWorkOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantityPerCart = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpWorkOrderDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameShort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityPerCart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(265, 433);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIn
            // 
            this.btnIn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(242)))));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.Appearance.Options.UseBackColor = true;
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Location = new System.Drawing.Point(179, 433);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(80, 40);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In (F1)";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 195);
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
            this.labelControl2.Size = new System.Drawing.Size(75, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ngày sản xuất";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 317);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 15);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Số lượng yêu cầu sản xuất";
            // 
            // txtModel
            // 
            this.txtModel.EditValue = "";
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(45, 218);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.Properties.Appearance.Options.UseFont = true;
            this.txtModel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtModel.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtModel.Properties.AutoHeight = false;
            this.txtModel.Size = new System.Drawing.Size(300, 30);
            this.txtModel.TabIndex = 6;
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
            // txtQuantity
            // 
            this.txtQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(45, 339);
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
            this.txtQuantity.TabIndex = 8;
            // 
            // txtPartNameShort
            // 
            this.txtPartNameShort.EditValue = "";
            this.txtPartNameShort.Enabled = false;
            this.txtPartNameShort.Location = new System.Drawing.Point(45, 279);
            this.txtPartNameShort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartNameShort.Name = "txtPartNameShort";
            this.txtPartNameShort.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartNameShort.Properties.Appearance.Options.UseFont = true;
            this.txtPartNameShort.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartNameShort.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartNameShort.Properties.AutoHeight = false;
            this.txtPartNameShort.Size = new System.Drawing.Size(300, 30);
            this.txtPartNameShort.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(45, 256);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 15);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Tên sản phẩm (Ngắn)";
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.EditValue = "";
            this.txtWorkOrderNo.Enabled = false;
            this.txtWorkOrderNo.Location = new System.Drawing.Point(45, 38);
            this.txtWorkOrderNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWorkOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtWorkOrderNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtWorkOrderNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtWorkOrderNo.Properties.AutoHeight = false;
            this.txtWorkOrderNo.Size = new System.Drawing.Size(300, 30);
            this.txtWorkOrderNo.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(45, 15);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 15);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Mã lệnh sản xuất";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.EditValue = "";
            this.txtPartNumber.Enabled = false;
            this.txtPartNumber.Location = new System.Drawing.Point(45, 157);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPartNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartNumber.Properties.AutoHeight = false;
            this.txtPartNumber.Size = new System.Drawing.Size(300, 30);
            this.txtPartNumber.TabIndex = 5;
            // 
            // txtQuantityPerCart
            // 
            this.txtQuantityPerCart.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQuantityPerCart.Location = new System.Drawing.Point(45, 396);
            this.txtQuantityPerCart.Name = "txtQuantityPerCart";
            this.txtQuantityPerCart.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantityPerCart.Properties.Appearance.Options.UseFont = true;
            this.txtQuantityPerCart.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantityPerCart.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtQuantityPerCart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantityPerCart.Properties.DisplayFormat.FormatString = "N0";
            this.txtQuantityPerCart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantityPerCart.Properties.EditFormat.FormatString = "N0";
            this.txtQuantityPerCart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantityPerCart.Properties.IsFloatValue = false;
            this.txtQuantityPerCart.Properties.Mask.EditMask = "N0";
            this.txtQuantityPerCart.Size = new System.Drawing.Size(300, 28);
            this.txtQuantityPerCart.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 374);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 15);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Số lượng / 1 xe";
            // 
            // dtpWorkOrderDate
            // 
            this.dtpWorkOrderDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpWorkOrderDate.Enabled = false;
            this.dtpWorkOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpWorkOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkOrderDate.Location = new System.Drawing.Point(45, 98);
            this.dtpWorkOrderDate.Name = "dtpWorkOrderDate";
            this.dtpWorkOrderDate.Size = new System.Drawing.Size(300, 29);
            this.dtpWorkOrderDate.TabIndex = 4;
            // 
            // frmPrintBarcodes
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(390, 488);
            this.Controls.Add(this.dtpWorkOrderDate);
            this.Controls.Add(this.txtQuantityPerCart);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.txtWorkOrderNo);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtPartNameShort);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintBarcodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In mã vạch";
            this.Load += new System.EventHandler(this.frmPrintBarcodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameShort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityPerCart.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtPartNameShort;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtWorkOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPartNumber;
        private DevExpress.XtraEditors.SpinEdit txtQuantityPerCart;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtpWorkOrderDate;
    }
}