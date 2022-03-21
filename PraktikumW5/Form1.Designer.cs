namespace PraktikumW5
{
    partial class FormMateri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblKoleksi = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rButtonRed = new System.Windows.Forms.RadioButton();
            this.rButtonBlue = new System.Windows.Forms.RadioButton();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(347, 9);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(60, 10);
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.Size = new System.Drawing.Size(266, 23);
            this.tBoxData.TabIndex = 1;
            this.tBoxData.TextChanged += new System.EventHandler(this.tBoxData_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // lblKoleksi
            // 
            this.lblKoleksi.AutoSize = true;
            this.lblKoleksi.Location = new System.Drawing.Point(16, 43);
            this.lblKoleksi.Name = "lblKoleksi";
            this.lblKoleksi.Size = new System.Drawing.Size(47, 15);
            this.lblKoleksi.TabIndex = 3;
            this.lblKoleksi.Text = "Koleksi:";
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(242, 43);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(47, 15);
            this.lblSetting.TabIndex = 4;
            this.lblSetting.Text = "Setting:";
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 15;
            this.listBoxKoleksi.Location = new System.Drawing.Point(16, 69);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(188, 229);
            this.listBoxKoleksi.TabIndex = 5;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rButtonRed
            // 
            this.rButtonRed.AutoSize = true;
            this.rButtonRed.Location = new System.Drawing.Point(261, 67);
            this.rButtonRed.Name = "rButtonRed";
            this.rButtonRed.Size = new System.Drawing.Size(96, 19);
            this.rButtonRed.TabIndex = 7;
            this.rButtonRed.TabStop = true;
            this.rButtonRed.Text = "Warna Merah";
            this.rButtonRed.UseVisualStyleBackColor = true;
            this.rButtonRed.CheckedChanged += new System.EventHandler(this.rButtonRed_CheckedChanged);
            // 
            // rButtonBlue
            // 
            this.rButtonBlue.AutoSize = true;
            this.rButtonBlue.Location = new System.Drawing.Point(261, 92);
            this.rButtonBlue.Name = "rButtonBlue";
            this.rButtonBlue.Size = new System.Drawing.Size(83, 19);
            this.rButtonBlue.TabIndex = 8;
            this.rButtonBlue.TabStop = true;
            this.rButtonBlue.Text = "Warna Biru";
            this.rButtonBlue.UseVisualStyleBackColor = true;
            this.rButtonBlue.CheckedChanged += new System.EventHandler(this.rButtonBlue_CheckedChanged);
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(295, 43);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(51, 19);
            this.checkBoxAktif.TabIndex = 9;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(242, 127);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(48, 15);
            this.lblOut.TabIndex = 10;
            this.lblOut.Text = "Output:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(242, 178);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(145, 45);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "[EMPTY]";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 309);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.rButtonBlue);
            this.Controls.Add(this.rButtonRed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblKoleksi);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tBoxData);
            this.Controls.Add(this.BtnAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormMateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAdd;
        private TextBox tBoxData;
        private Label lblData;
        private Label lblKoleksi;
        private Label lblSetting;
        private ListBox listBoxKoleksi;
        private Button btnClear;
        private RadioButton rButtonRed;
        private RadioButton rButtonBlue;
        private CheckBox checkBoxAktif;
        private Label lblOut;
        private Label lblOutput;
    }
}