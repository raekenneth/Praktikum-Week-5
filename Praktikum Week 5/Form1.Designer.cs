namespace Praktikum_Week_5
{
    partial class FormWeek5
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
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.labelHalo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(62, 31);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(405, 23);
            this.textBoxData.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(485, 31);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(22, 34);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(22, 73);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(47, 15);
            this.labelKoleksi.TabIndex = 3;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(366, 72);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(51, 19);
            this.checkBoxAktif.TabIndex = 4;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(313, 72);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(47, 15);
            this.labelSetting.TabIndex = 5;
            this.labelSetting.Text = "Setting:";
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Checked = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(338, 97);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(96, 19);
            this.radioButtonMerah.TabIndex = 6;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(338, 122);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(83, 19);
            this.radioButtonBiru.TabIndex = 7;
            this.radioButtonBiru.TabStop = true;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(313, 163);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(48, 15);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(313, 318);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(257, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 15;
            this.listBoxKoleksi.Location = new System.Drawing.Point(22, 97);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(228, 244);
            this.listBoxKoleksi.TabIndex = 11;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // labelHalo
            // 
            this.labelHalo.AutoSize = true;
            this.labelHalo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHalo.Location = new System.Drawing.Point(366, 206);
            this.labelHalo.Name = "labelHalo";
            this.labelHalo.Size = new System.Drawing.Size(0, 50);
            this.labelHalo.TabIndex = 12;
            // 
            // FormWeek5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHalo);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxData);
            this.Name = "FormWeek5";
            this.Text = "Form Materi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxData;
        private Button buttonAdd;
        private Label labelData;
        private Label labelKoleksi;
        private CheckBox checkBoxAktif;
        private Label labelSetting;
        private RadioButton radioButtonMerah;
        private RadioButton radioButtonBiru;
        private Label labelOutput;
        private Label label1;
        private Button buttonClear;
        private ListBox listBoxKoleksi;
        private Label labelHalo;
    }
}