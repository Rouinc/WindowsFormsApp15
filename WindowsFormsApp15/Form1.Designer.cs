namespace WindowsFormsApp15
{
    partial class Formmateri
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
            this.labeldataa = new System.Windows.Forms.Label();
            this.textboxinput = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.labelkoleksi = new System.Windows.Forms.Label();
            this.listboxinput = new System.Windows.Forms.ListBox();
            this.labelsetting = new System.Windows.Forms.Label();
            this.checkBoxaktif = new System.Windows.Forms.CheckBox();
            this.radiobuttonmerah = new System.Windows.Forms.RadioButton();
            this.radioButtonbiru = new System.Windows.Forms.RadioButton();
            this.labeloutput = new System.Windows.Forms.Label();
            this.labeloutputtt = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.labelout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeldataa
            // 
            this.labeldataa.AutoSize = true;
            this.labeldataa.Location = new System.Drawing.Point(12, 26);
            this.labeldataa.Name = "labeldataa";
            this.labeldataa.Size = new System.Drawing.Size(48, 20);
            this.labeldataa.TabIndex = 0;
            this.labeldataa.Text = "Data:";
            // 
            // textboxinput
            // 
            this.textboxinput.Location = new System.Drawing.Point(118, 26);
            this.textboxinput.Name = "textboxinput";
            this.textboxinput.Size = new System.Drawing.Size(351, 26);
            this.textboxinput.TabIndex = 1;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(523, 26);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(84, 33);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // labelkoleksi
            // 
            this.labelkoleksi.AutoSize = true;
            this.labelkoleksi.Location = new System.Drawing.Point(12, 83);
            this.labelkoleksi.Name = "labelkoleksi";
            this.labelkoleksi.Size = new System.Drawing.Size(63, 20);
            this.labelkoleksi.TabIndex = 3;
            this.labelkoleksi.Text = "Koleksi:";
            // 
            // listboxinput
            // 
            this.listboxinput.FormattingEnabled = true;
            this.listboxinput.ItemHeight = 20;
            this.listboxinput.Location = new System.Drawing.Point(16, 119);
            this.listboxinput.Name = "listboxinput";
            this.listboxinput.Size = new System.Drawing.Size(226, 264);
            this.listboxinput.TabIndex = 4;
            this.listboxinput.SelectedIndexChanged += new System.EventHandler(this.listboxinput_SelectedIndexChanged);
            // 
            // labelsetting
            // 
            this.labelsetting.AutoSize = true;
            this.labelsetting.Location = new System.Drawing.Point(319, 83);
            this.labelsetting.Name = "labelsetting";
            this.labelsetting.Size = new System.Drawing.Size(64, 20);
            this.labelsetting.TabIndex = 5;
            this.labelsetting.Text = "Setting:";
            // 
            // checkBoxaktif
            // 
            this.checkBoxaktif.AutoSize = true;
            this.checkBoxaktif.Location = new System.Drawing.Point(422, 83);
            this.checkBoxaktif.Name = "checkBoxaktif";
            this.checkBoxaktif.Size = new System.Drawing.Size(67, 24);
            this.checkBoxaktif.TabIndex = 6;
            this.checkBoxaktif.Text = "Aktif";
            this.checkBoxaktif.UseVisualStyleBackColor = true;
            this.checkBoxaktif.CheckedChanged += new System.EventHandler(this.checkBoxaktif_CheckedChanged);
            // 
            // radiobuttonmerah
            // 
            this.radiobuttonmerah.AutoSize = true;
            this.radiobuttonmerah.Checked = true;
            this.radiobuttonmerah.Location = new System.Drawing.Point(363, 119);
            this.radiobuttonmerah.Name = "radiobuttonmerah";
            this.radiobuttonmerah.Size = new System.Drawing.Size(130, 24);
            this.radiobuttonmerah.TabIndex = 7;
            this.radiobuttonmerah.TabStop = true;
            this.radiobuttonmerah.Text = "Warna Merah";
            this.radiobuttonmerah.UseVisualStyleBackColor = true;
            this.radiobuttonmerah.CheckedChanged += new System.EventHandler(this.radiobuttonmerah_CheckedChanged);
            // 
            // radioButtonbiru
            // 
            this.radioButtonbiru.AutoSize = true;
            this.radioButtonbiru.Location = new System.Drawing.Point(363, 149);
            this.radioButtonbiru.Name = "radioButtonbiru";
            this.radioButtonbiru.Size = new System.Drawing.Size(113, 24);
            this.radioButtonbiru.TabIndex = 8;
            this.radioButtonbiru.Text = "Warna Biru";
            this.radioButtonbiru.UseVisualStyleBackColor = true;
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(319, 201);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(62, 20);
            this.labeloutput.TabIndex = 9;
            this.labeloutput.Text = "Output:";
            // 
            // labeloutputtt
            // 
            this.labeloutputtt.AutoSize = true;
            this.labeloutputtt.Location = new System.Drawing.Point(448, 311);
            this.labeloutputtt.Name = "labeloutputtt";
            this.labeloutputtt.Size = new System.Drawing.Size(0, 20);
            this.labeloutputtt.TabIndex = 10;
            this.labeloutputtt.Click += new System.EventHandler(this.labeloutputtt_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(323, 422);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(421, 33);
            this.buttonclear.TabIndex = 11;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // labelout
            // 
            this.labelout.AutoSize = true;
            this.labelout.Location = new System.Drawing.Point(483, 277);
            this.labelout.Name = "labelout";
            this.labelout.Size = new System.Drawing.Size(0, 20);
            this.labelout.TabIndex = 12;
            // 
            // Formmateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.labelout);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.labeloutputtt);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.radioButtonbiru);
            this.Controls.Add(this.radiobuttonmerah);
            this.Controls.Add(this.checkBoxaktif);
            this.Controls.Add(this.labelsetting);
            this.Controls.Add(this.listboxinput);
            this.Controls.Add(this.labelkoleksi);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textboxinput);
            this.Controls.Add(this.labeldataa);
            this.Name = "Formmateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.Formmateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldataa;
        private System.Windows.Forms.TextBox textboxinput;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Label labelkoleksi;
        private System.Windows.Forms.ListBox listboxinput;
        private System.Windows.Forms.Label labelsetting;
        private System.Windows.Forms.CheckBox checkBoxaktif;
        private System.Windows.Forms.RadioButton radiobuttonmerah;
        private System.Windows.Forms.RadioButton radioButtonbiru;
        private System.Windows.Forms.Label labeloutput;
        private System.Windows.Forms.Label labeloutputtt;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Label labelout;
    }
}

