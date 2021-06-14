
namespace BestOilWinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oiltotallbl = new System.Windows.Forms.Label();
            this.Meblegtextbox = new System.Windows.Forms.TextBox();
            this.LitrtextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Meblegradiobtn = new System.Windows.Forms.RadioButton();
            this.Litrradiobtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BenzinLbl = new System.Windows.Forms.Label();
            this.Minikafegroupbox = new System.Windows.Forms.GroupBox();
            this.colocount = new System.Windows.Forms.TextBox();
            this.Freecount = new System.Windows.Forms.TextBox();
            this.HhamburgerCount = new System.Windows.Forms.TextBox();
            this.HotDogCount = new System.Windows.Forms.TextBox();
            this.CafeTotal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CafeTotalLabel = new System.Windows.Forms.Label();
            this.colatxtbox = new System.Windows.Forms.TextBox();
            this.Freetxtbox = new System.Windows.Forms.TextBox();
            this.Hamburgertxtbox = new System.Windows.Forms.TextBox();
            this.HotDogTextBox = new System.Windows.Forms.TextBox();
            this.CocoColacheckbox = new System.Windows.Forms.CheckBox();
            this.kartofFreecheckbox = new System.Windows.Forms.CheckBox();
            this.Hamburgercheckboc = new System.Windows.Forms.CheckBox();
            this.HotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalSalaryy = new System.Windows.Forms.Label();
            this.Buybtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Minikafegroupbox.SuspendLayout();
            this.CafeTotal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.Meblegtextbox);
            this.groupBox1.Controls.Add(this.LitrtextBox);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.PriceLbl);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.BenzinLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OilSelection";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.oiltotallbl);
            this.groupBox5.Location = new System.Drawing.Point(6, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 85);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OilTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azn";
            // 
            // oiltotallbl
            // 
            this.oiltotallbl.AutoSize = true;
            this.oiltotallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oiltotallbl.Location = new System.Drawing.Point(151, 33);
            this.oiltotallbl.Name = "oiltotallbl";
            this.oiltotallbl.Size = new System.Drawing.Size(26, 29);
            this.oiltotallbl.TabIndex = 0;
            this.oiltotallbl.Text = "0";
            // 
            // Meblegtextbox
            // 
            this.Meblegtextbox.Enabled = false;
            this.Meblegtextbox.Location = new System.Drawing.Point(162, 237);
            this.Meblegtextbox.Name = "Meblegtextbox";
            this.Meblegtextbox.Size = new System.Drawing.Size(97, 22);
            this.Meblegtextbox.TabIndex = 6;
            this.Meblegtextbox.TextChanged += new System.EventHandler(this.Meblegtextbox_TextChanged);
            // 
            // LitrtextBox
            // 
            this.LitrtextBox.Enabled = false;
            this.LitrtextBox.HideSelection = false;
            this.LitrtextBox.Location = new System.Drawing.Point(162, 206);
            this.LitrtextBox.Name = "LitrtextBox";
            this.LitrtextBox.Size = new System.Drawing.Size(97, 22);
            this.LitrtextBox.TabIndex = 5;
            this.LitrtextBox.TextChanged += new System.EventHandler(this.LitrtextBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Meblegradiobtn);
            this.groupBox4.Controls.Add(this.Litrradiobtn);
            this.groupBox4.Location = new System.Drawing.Point(20, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 83);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Meblegradiobtn
            // 
            this.Meblegradiobtn.AutoSize = true;
            this.Meblegradiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meblegradiobtn.Location = new System.Drawing.Point(6, 47);
            this.Meblegradiobtn.Name = "Meblegradiobtn";
            this.Meblegradiobtn.Size = new System.Drawing.Size(74, 22);
            this.Meblegradiobtn.TabIndex = 1;
            this.Meblegradiobtn.TabStop = true;
            this.Meblegradiobtn.Text = "Mebleg";
            this.Meblegradiobtn.UseVisualStyleBackColor = true;
            this.Meblegradiobtn.CheckedChanged += new System.EventHandler(this.Meblegradiobtn_CheckedChanged);
            // 
            // Litrradiobtn
            // 
            this.Litrradiobtn.AutoSize = true;
            this.Litrradiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Litrradiobtn.Location = new System.Drawing.Point(6, 19);
            this.Litrradiobtn.Name = "Litrradiobtn";
            this.Litrradiobtn.Size = new System.Drawing.Size(46, 22);
            this.Litrradiobtn.TabIndex = 0;
            this.Litrradiobtn.TabStop = true;
            this.Litrradiobtn.Text = "Litr";
            this.Litrradiobtn.UseVisualStyleBackColor = true;
            this.Litrradiobtn.CheckedChanged += new System.EventHandler(this.Litrradiobtn_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 3;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(16, 95);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(69, 24);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Qiymet";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BenzinLbl
            // 
            this.BenzinLbl.AutoSize = true;
            this.BenzinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenzinLbl.Location = new System.Drawing.Point(16, 34);
            this.BenzinLbl.Name = "BenzinLbl";
            this.BenzinLbl.Size = new System.Drawing.Size(68, 24);
            this.BenzinLbl.TabIndex = 0;
            this.BenzinLbl.Text = "Benzin";
            // 
            // Minikafegroupbox
            // 
            this.Minikafegroupbox.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Minikafegroupbox.Controls.Add(this.colocount);
            this.Minikafegroupbox.Controls.Add(this.Freecount);
            this.Minikafegroupbox.Controls.Add(this.HhamburgerCount);
            this.Minikafegroupbox.Controls.Add(this.HotDogCount);
            this.Minikafegroupbox.Controls.Add(this.CafeTotal);
            this.Minikafegroupbox.Controls.Add(this.colatxtbox);
            this.Minikafegroupbox.Controls.Add(this.Freetxtbox);
            this.Minikafegroupbox.Controls.Add(this.Hamburgertxtbox);
            this.Minikafegroupbox.Controls.Add(this.HotDogTextBox);
            this.Minikafegroupbox.Controls.Add(this.CocoColacheckbox);
            this.Minikafegroupbox.Controls.Add(this.kartofFreecheckbox);
            this.Minikafegroupbox.Controls.Add(this.Hamburgercheckboc);
            this.Minikafegroupbox.Controls.Add(this.HotDogCheckBox);
            this.Minikafegroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minikafegroupbox.Location = new System.Drawing.Point(474, 27);
            this.Minikafegroupbox.Name = "Minikafegroupbox";
            this.Minikafegroupbox.Size = new System.Drawing.Size(277, 401);
            this.Minikafegroupbox.TabIndex = 1;
            this.Minikafegroupbox.TabStop = false;
            this.Minikafegroupbox.Text = "Mini-Kafe";
            // 
            // colocount
            // 
            this.colocount.Enabled = false;
            this.colocount.Location = new System.Drawing.Point(210, 136);
            this.colocount.Multiline = true;
            this.colocount.Name = "colocount";
            this.colocount.Size = new System.Drawing.Size(61, 20);
            this.colocount.TabIndex = 12;
            this.colocount.TextChanged += new System.EventHandler(this.colocount_TextChanged);
            // 
            // Freecount
            // 
            this.Freecount.Enabled = false;
            this.Freecount.Location = new System.Drawing.Point(210, 109);
            this.Freecount.Multiline = true;
            this.Freecount.Name = "Freecount";
            this.Freecount.Size = new System.Drawing.Size(61, 20);
            this.Freecount.TabIndex = 11;
            this.Freecount.TextChanged += new System.EventHandler(this.Freecount_TextChanged);
            // 
            // HhamburgerCount
            // 
            this.HhamburgerCount.Enabled = false;
            this.HhamburgerCount.Location = new System.Drawing.Point(210, 76);
            this.HhamburgerCount.Multiline = true;
            this.HhamburgerCount.Name = "HhamburgerCount";
            this.HhamburgerCount.Size = new System.Drawing.Size(61, 20);
            this.HhamburgerCount.TabIndex = 10;
            this.HhamburgerCount.TextChanged += new System.EventHandler(this.HhamburgerCount_TextChanged);
            // 
            // HotDogCount
            // 
            this.HotDogCount.Enabled = false;
            this.HotDogCount.Location = new System.Drawing.Point(210, 41);
            this.HotDogCount.Multiline = true;
            this.HotDogCount.Name = "HotDogCount";
            this.HotDogCount.Size = new System.Drawing.Size(61, 20);
            this.HotDogCount.TabIndex = 9;
            this.HotDogCount.TextChanged += new System.EventHandler(this.HotDogCount_TextChanged);
            // 
            // CafeTotal
            // 
            this.CafeTotal.Controls.Add(this.label3);
            this.CafeTotal.Controls.Add(this.CafeTotalLabel);
            this.CafeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CafeTotal.Location = new System.Drawing.Point(6, 310);
            this.CafeTotal.Name = "CafeTotal";
            this.CafeTotal.Size = new System.Drawing.Size(265, 85);
            this.CafeTotal.TabIndex = 8;
            this.CafeTotal.TabStop = false;
            this.CafeTotal.Text = "CafeTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Azn";
            // 
            // CafeTotalLabel
            // 
            this.CafeTotalLabel.AutoSize = true;
            this.CafeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CafeTotalLabel.Location = new System.Drawing.Point(165, 33);
            this.CafeTotalLabel.Name = "CafeTotalLabel";
            this.CafeTotalLabel.Size = new System.Drawing.Size(26, 29);
            this.CafeTotalLabel.TabIndex = 2;
            this.CafeTotalLabel.Text = "0";
            // 
            // colatxtbox
            // 
            this.colatxtbox.Enabled = false;
            this.colatxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colatxtbox.Location = new System.Drawing.Point(136, 136);
            this.colatxtbox.Multiline = true;
            this.colatxtbox.Name = "colatxtbox";
            this.colatxtbox.Size = new System.Drawing.Size(61, 20);
            this.colatxtbox.TabIndex = 7;
            // 
            // Freetxtbox
            // 
            this.Freetxtbox.Enabled = false;
            this.Freetxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freetxtbox.Location = new System.Drawing.Point(136, 108);
            this.Freetxtbox.Multiline = true;
            this.Freetxtbox.Name = "Freetxtbox";
            this.Freetxtbox.Size = new System.Drawing.Size(61, 20);
            this.Freetxtbox.TabIndex = 6;
            // 
            // Hamburgertxtbox
            // 
            this.Hamburgertxtbox.Enabled = false;
            this.Hamburgertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hamburgertxtbox.Location = new System.Drawing.Point(136, 76);
            this.Hamburgertxtbox.Multiline = true;
            this.Hamburgertxtbox.Name = "Hamburgertxtbox";
            this.Hamburgertxtbox.Size = new System.Drawing.Size(61, 20);
            this.Hamburgertxtbox.TabIndex = 5;
            // 
            // HotDogTextBox
            // 
            this.HotDogTextBox.Enabled = false;
            this.HotDogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogTextBox.Location = new System.Drawing.Point(136, 41);
            this.HotDogTextBox.Multiline = true;
            this.HotDogTextBox.Name = "HotDogTextBox";
            this.HotDogTextBox.Size = new System.Drawing.Size(61, 20);
            this.HotDogTextBox.TabIndex = 4;
            // 
            // CocoColacheckbox
            // 
            this.CocoColacheckbox.AutoSize = true;
            this.CocoColacheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CocoColacheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocoColacheckbox.Location = new System.Drawing.Point(21, 135);
            this.CocoColacheckbox.Name = "CocoColacheckbox";
            this.CocoColacheckbox.Size = new System.Drawing.Size(97, 21);
            this.CocoColacheckbox.TabIndex = 3;
            this.CocoColacheckbox.Text = "Coco-Cola";
            this.CocoColacheckbox.UseVisualStyleBackColor = false;
            this.CocoColacheckbox.CheckedChanged += new System.EventHandler(this.CocoColacheckbox_CheckedChanged);
            // 
            // kartofFreecheckbox
            // 
            this.kartofFreecheckbox.AutoSize = true;
            this.kartofFreecheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kartofFreecheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kartofFreecheckbox.Location = new System.Drawing.Point(21, 108);
            this.kartofFreecheckbox.Name = "kartofFreecheckbox";
            this.kartofFreecheckbox.Size = new System.Drawing.Size(99, 21);
            this.kartofFreecheckbox.TabIndex = 2;
            this.kartofFreecheckbox.Text = "Kartof-Free";
            this.kartofFreecheckbox.UseVisualStyleBackColor = false;
            this.kartofFreecheckbox.CheckedChanged += new System.EventHandler(this.kartofFreecheckbox_CheckedChanged);
            // 
            // Hamburgercheckboc
            // 
            this.Hamburgercheckboc.AutoSize = true;
            this.Hamburgercheckboc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Hamburgercheckboc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hamburgercheckboc.Location = new System.Drawing.Point(21, 76);
            this.Hamburgercheckboc.Name = "Hamburgercheckboc";
            this.Hamburgercheckboc.Size = new System.Drawing.Size(101, 21);
            this.Hamburgercheckboc.TabIndex = 1;
            this.Hamburgercheckboc.Text = "Hamburger";
            this.Hamburgercheckboc.UseVisualStyleBackColor = false;
            this.Hamburgercheckboc.CheckedChanged += new System.EventHandler(this.Hamburgercheckboc_CheckedChanged);
            // 
            // HotDogCheckBox
            // 
            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HotDogCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogCheckBox.Location = new System.Drawing.Point(21, 40);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.Size = new System.Drawing.Size(84, 21);
            this.HotDogCheckBox.TabIndex = 0;
            this.HotDogCheckBox.Text = "Hot-Dog";
            this.HotDogCheckBox.UseVisualStyleBackColor = false;
            this.HotDogCheckBox.CheckedChanged += new System.EventHandler(this.HotDogCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TotalSalaryy);
            this.groupBox3.Controls.Add(this.Buybtn);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(29, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 137);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Azn";
            // 
            // TotalSalaryy
            // 
            this.TotalSalaryy.AutoSize = true;
            this.TotalSalaryy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalaryy.Location = new System.Drawing.Point(515, 71);
            this.TotalSalaryy.Name = "TotalSalaryy";
            this.TotalSalaryy.Size = new System.Drawing.Size(36, 39);
            this.TotalSalaryy.TabIndex = 2;
            this.TotalSalaryy.Text = "0";
            // 
            // Buybtn
            // 
            this.Buybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buybtn.Location = new System.Drawing.Point(122, 55);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(149, 55);
            this.Buybtn.TabIndex = 1;
            this.Buybtn.Text = "Buy";
            this.Buybtn.UseVisualStyleBackColor = true;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestOilWinForm.Properties.Resources.salary;
            this.pictureBox1.Location = new System.Drawing.Point(26, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(770, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Minikafegroupbox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(786, 653);
            this.MinimumSize = new System.Drawing.Size(786, 653);
            this.Name = "Form1";
            this.Text = "Best Oil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Minikafegroupbox.ResumeLayout(false);
            this.Minikafegroupbox.PerformLayout();
            this.CafeTotal.ResumeLayout(false);
            this.CafeTotal.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Minikafegroupbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BenzinLbl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oiltotallbl;
        private System.Windows.Forms.TextBox Meblegtextbox;
        private System.Windows.Forms.TextBox LitrtextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Meblegradiobtn;
        private System.Windows.Forms.RadioButton Litrradiobtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox colatxtbox;
        private System.Windows.Forms.TextBox Freetxtbox;
        private System.Windows.Forms.TextBox Hamburgertxtbox;
        private System.Windows.Forms.TextBox HotDogTextBox;
        private System.Windows.Forms.CheckBox CocoColacheckbox;
        private System.Windows.Forms.CheckBox kartofFreecheckbox;
        private System.Windows.Forms.CheckBox Hamburgercheckboc;
        private System.Windows.Forms.CheckBox HotDogCheckBox;
        private System.Windows.Forms.GroupBox CafeTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CafeTotalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalSalaryy;
        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.TextBox colocount;
        private System.Windows.Forms.TextBox Freecount;
        private System.Windows.Forms.TextBox HhamburgerCount;
        private System.Windows.Forms.TextBox HotDogCount;
    }
}

