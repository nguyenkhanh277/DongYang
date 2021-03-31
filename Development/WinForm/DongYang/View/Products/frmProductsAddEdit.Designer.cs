namespace DongYang.View.Products
{
    partial class frmProductsAddEdit
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chkUsing = new System.Windows.Forms.RadioButton();
            this.chkNoUse = new System.Windows.Forms.RadioButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtPartNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtPartName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartNameShort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameShort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(265, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(242)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(179, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu (F1)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 78);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.EditValue = "";
            this.txtModel.Location = new System.Drawing.Point(45, 40);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.Properties.Appearance.Options.UseFont = true;
            this.txtModel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtModel.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtModel.Properties.AutoHeight = false;
            this.txtModel.Size = new System.Drawing.Size(300, 30);
            this.txtModel.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(45, 332);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 15);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Trạng thái";
            // 
            // chkUsing
            // 
            this.chkUsing.AutoSize = true;
            this.chkUsing.BackColor = System.Drawing.Color.Transparent;
            this.chkUsing.Checked = true;
            this.chkUsing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkUsing.Location = new System.Drawing.Point(10, 4);
            this.chkUsing.Name = "chkUsing";
            this.chkUsing.Size = new System.Drawing.Size(69, 19);
            this.chkUsing.TabIndex = 0;
            this.chkUsing.TabStop = true;
            this.chkUsing.Text = "Sử dụng";
            this.chkUsing.UseVisualStyleBackColor = false;
            this.chkUsing.CheckedChanged += new System.EventHandler(this.chkUsing_CheckedChanged);
            // 
            // chkNoUse
            // 
            this.chkNoUse.AutoSize = true;
            this.chkNoUse.BackColor = System.Drawing.Color.Transparent;
            this.chkNoUse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkNoUse.Location = new System.Drawing.Point(94, 4);
            this.chkNoUse.Name = "chkNoUse";
            this.chkNoUse.Size = new System.Drawing.Size(85, 19);
            this.chkNoUse.TabIndex = 1;
            this.chkNoUse.Text = "Ko sử dụng";
            this.chkNoUse.UseVisualStyleBackColor = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkUsing);
            this.panelControl2.Controls.Add(this.chkNoUse);
            this.panelControl2.Location = new System.Drawing.Point(45, 356);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(300, 30);
            this.panelControl2.TabIndex = 5;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.EditValue = "";
            this.txtPartNumber.Location = new System.Drawing.Point(45, 101);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPartNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartNumber.Properties.AutoHeight = false;
            this.txtPartNumber.Size = new System.Drawing.Size(300, 30);
            this.txtPartNumber.TabIndex = 1;
            // 
            // txtPartName
            // 
            this.txtPartName.EditValue = "";
            this.txtPartName.Location = new System.Drawing.Point(45, 162);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartName.Properties.Appearance.Options.UseFont = true;
            this.txtPartName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartName.Properties.AutoHeight = false;
            this.txtPartName.Size = new System.Drawing.Size(300, 30);
            this.txtPartName.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 139);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 15);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Tên sản phẩm (Dài)";
            // 
            // txtPartNameShort
            // 
            this.txtPartNameShort.EditValue = "";
            this.txtPartNameShort.Location = new System.Drawing.Point(45, 223);
            this.txtPartNameShort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartNameShort.Name = "txtPartNameShort";
            this.txtPartNameShort.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartNameShort.Properties.Appearance.Options.UseFont = true;
            this.txtPartNameShort.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPartNameShort.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPartNameShort.Properties.AutoHeight = false;
            this.txtPartNameShort.Size = new System.Drawing.Size(300, 30);
            this.txtPartNameShort.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 200);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 15);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Tên sản phẩm (Ngắn)";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(45, 285);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNote.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNote.Size = new System.Drawing.Size(300, 30);
            this.txtNote.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 261);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 15);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Ghi chú";
            // 
            // frmProductsAddEdit
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(390, 453);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtPartNameShort);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductsAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmProductsAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameShort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.RadioButton chkUsing;
        private System.Windows.Forms.RadioButton chkNoUse;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtPartNumber;
        private DevExpress.XtraEditors.TextEdit txtPartName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPartNameShort;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}