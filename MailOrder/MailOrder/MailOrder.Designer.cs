namespace MailOrder
{
    partial class Sales_BonusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_BonusForm));
            this.EmpName_Label = new System.Windows.Forms.Label();
            this.Eng_RadioBtn = new System.Windows.Forms.RadioButton();
            this.FrRadio_Btn = new System.Windows.Forms.RadioButton();
            this.EmpID_Label = new System.Windows.Forms.Label();
            this.HrsWork_Label = new System.Windows.Forms.Label();
            this.TotSales_Label = new System.Windows.Forms.Label();
            this.SalesBonus_Label = new System.Windows.Forms.Label();
            this.EmpName_TextBox = new System.Windows.Forms.TextBox();
            this.EmpID_TextBox = new System.Windows.Forms.TextBox();
            this.HrsWork_TextBox = new System.Windows.Forms.TextBox();
            this.TotSales_TextBox = new System.Windows.Forms.TextBox();
            this.SalesBonus_TextBox = new System.Windows.Forms.TextBox();
            this.Cal_Btn = new System.Windows.Forms.Button();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.Lang_GroupBox = new System.Windows.Forms.GroupBox();
            this.HinRadio_Btn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.Lang_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpName_Label
            // 
            this.EmpName_Label.AutoSize = true;
            this.EmpName_Label.Location = new System.Drawing.Point(52, 190);
            this.EmpName_Label.Name = "EmpName_Label";
            this.EmpName_Label.Size = new System.Drawing.Size(121, 17);
            this.EmpName_Label.TabIndex = 1;
            this.EmpName_Label.Text = "Employee\'s Name";
            this.EmpName_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Eng_RadioBtn
            // 
            this.Eng_RadioBtn.AutoSize = true;
            this.Eng_RadioBtn.Checked = true;
            this.Eng_RadioBtn.Location = new System.Drawing.Point(11, 34);
            this.Eng_RadioBtn.Name = "Eng_RadioBtn";
            this.Eng_RadioBtn.Size = new System.Drawing.Size(75, 21);
            this.Eng_RadioBtn.TabIndex = 2;
            this.Eng_RadioBtn.TabStop = true;
            this.Eng_RadioBtn.Text = "English";
            this.Eng_RadioBtn.UseVisualStyleBackColor = true;
            this.Eng_RadioBtn.CheckedChanged += new System.EventHandler(this.Eng_RadioBtn_CheckedChanged);
            // 
            // FrRadio_Btn
            // 
            this.FrRadio_Btn.AutoSize = true;
            this.FrRadio_Btn.Location = new System.Drawing.Point(11, 61);
            this.FrRadio_Btn.Name = "FrRadio_Btn";
            this.FrRadio_Btn.Size = new System.Drawing.Size(83, 21);
            this.FrRadio_Btn.TabIndex = 3;
            this.FrRadio_Btn.TabStop = true;
            this.FrRadio_Btn.Text = "Français";
            this.FrRadio_Btn.UseVisualStyleBackColor = true;
            this.FrRadio_Btn.CheckedChanged += new System.EventHandler(this.FrRadio_Btn_CheckedChanged);
            // 
            // EmpID_Label
            // 
            this.EmpID_Label.AutoSize = true;
            this.EmpID_Label.Location = new System.Drawing.Point(52, 228);
            this.EmpID_Label.Name = "EmpID_Label";
            this.EmpID_Label.Size = new System.Drawing.Size(91, 17);
            this.EmpID_Label.TabIndex = 4;
            this.EmpID_Label.Text = "Employee ID:";
            // 
            // HrsWork_Label
            // 
            this.HrsWork_Label.AutoSize = true;
            this.HrsWork_Label.Location = new System.Drawing.Point(52, 286);
            this.HrsWork_Label.Name = "HrsWork_Label";
            this.HrsWork_Label.Size = new System.Drawing.Size(107, 17);
            this.HrsWork_Label.TabIndex = 5;
            this.HrsWork_Label.Text = "Hours Worked :";
            // 
            // TotSales_Label
            // 
            this.TotSales_Label.AutoSize = true;
            this.TotSales_Label.Location = new System.Drawing.Point(52, 321);
            this.TotSales_Label.Name = "TotSales_Label";
            this.TotSales_Label.Size = new System.Drawing.Size(87, 17);
            this.TotSales_Label.TabIndex = 6;
            this.TotSales_Label.Text = "Total Sales :";
            // 
            // SalesBonus_Label
            // 
            this.SalesBonus_Label.AutoSize = true;
            this.SalesBonus_Label.Location = new System.Drawing.Point(52, 374);
            this.SalesBonus_Label.Name = "SalesBonus_Label";
            this.SalesBonus_Label.Size = new System.Drawing.Size(95, 17);
            this.SalesBonus_Label.TabIndex = 7;
            this.SalesBonus_Label.Text = "Sales Bonus :";
            // 
            // EmpName_TextBox
            // 
            this.EmpName_TextBox.Location = new System.Drawing.Point(195, 190);
            this.EmpName_TextBox.Name = "EmpName_TextBox";
            this.EmpName_TextBox.Size = new System.Drawing.Size(255, 22);
            this.EmpName_TextBox.TabIndex = 8;
            // 
            // EmpID_TextBox
            // 
            this.EmpID_TextBox.Location = new System.Drawing.Point(195, 223);
            this.EmpID_TextBox.Name = "EmpID_TextBox";
            this.EmpID_TextBox.Size = new System.Drawing.Size(115, 22);
            this.EmpID_TextBox.TabIndex = 9;
            // 
            // HrsWork_TextBox
            // 
            this.HrsWork_TextBox.Location = new System.Drawing.Point(195, 286);
            this.HrsWork_TextBox.Name = "HrsWork_TextBox";
            this.HrsWork_TextBox.Size = new System.Drawing.Size(115, 22);
            this.HrsWork_TextBox.TabIndex = 10;
            this.HrsWork_TextBox.TextChanged += new System.EventHandler(this.HrsWork_TextBox_TextChanged);
            // 
            // TotSales_TextBox
            // 
            this.TotSales_TextBox.Location = new System.Drawing.Point(195, 321);
            this.TotSales_TextBox.Name = "TotSales_TextBox";
            this.TotSales_TextBox.Size = new System.Drawing.Size(115, 22);
            this.TotSales_TextBox.TabIndex = 11;
            // 
            // SalesBonus_TextBox
            // 
            this.SalesBonus_TextBox.Location = new System.Drawing.Point(195, 374);
            this.SalesBonus_TextBox.Name = "SalesBonus_TextBox";
            this.SalesBonus_TextBox.ReadOnly = true;
            this.SalesBonus_TextBox.Size = new System.Drawing.Size(115, 22);
            this.SalesBonus_TextBox.TabIndex = 12;
            // 
            // Cal_Btn
            // 
            this.Cal_Btn.Location = new System.Drawing.Point(39, 438);
            this.Cal_Btn.Name = "Cal_Btn";
            this.Cal_Btn.Size = new System.Drawing.Size(92, 40);
            this.Cal_Btn.TabIndex = 13;
            this.Cal_Btn.Text = "Calculate";
            this.Cal_Btn.UseVisualStyleBackColor = true;
            this.Cal_Btn.Click += new System.EventHandler(this.Cal_Btn_Click);
            // 
            // Print_Btn
            // 
            this.Print_Btn.Location = new System.Drawing.Point(246, 438);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(92, 40);
            this.Print_Btn.TabIndex = 14;
            this.Print_Btn.Text = "Print";
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Location = new System.Drawing.Point(453, 438);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(92, 40);
            this.Clear_Btn.TabIndex = 15;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // Picture_Box
            // 
            this.Picture_Box.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Box.Image")));
            this.Picture_Box.Location = new System.Drawing.Point(55, 3);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(255, 165);
            this.Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Box.TabIndex = 16;
            this.Picture_Box.TabStop = false;
            // 
            // Lang_GroupBox
            // 
            this.Lang_GroupBox.Controls.Add(this.HinRadio_Btn);
            this.Lang_GroupBox.Controls.Add(this.Eng_RadioBtn);
            this.Lang_GroupBox.Controls.Add(this.FrRadio_Btn);
            this.Lang_GroupBox.Location = new System.Drawing.Point(345, 51);
            this.Lang_GroupBox.Name = "Lang_GroupBox";
            this.Lang_GroupBox.Size = new System.Drawing.Size(212, 117);
            this.Lang_GroupBox.TabIndex = 17;
            this.Lang_GroupBox.TabStop = false;
            this.Lang_GroupBox.Text = "Languages";
            // 
            // HinRadio_Btn
            // 
            this.HinRadio_Btn.AutoSize = true;
            this.HinRadio_Btn.Location = new System.Drawing.Point(11, 90);
            this.HinRadio_Btn.Name = "HinRadio_Btn";
            this.HinRadio_Btn.Size = new System.Drawing.Size(61, 21);
            this.HinRadio_Btn.TabIndex = 4;
            this.HinRadio_Btn.TabStop = true;
            this.HinRadio_Btn.Text = "Hindi";
            this.HinRadio_Btn.UseVisualStyleBackColor = true;
            this.HinRadio_Btn.CheckedChanged += new System.EventHandler(this.HinRadio_Btn_CheckedChanged);
            // 
            // Sales_BonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 496);
            this.Controls.Add(this.Lang_GroupBox);
            this.Controls.Add(this.Picture_Box);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.Print_Btn);
            this.Controls.Add(this.Cal_Btn);
            this.Controls.Add(this.SalesBonus_TextBox);
            this.Controls.Add(this.TotSales_TextBox);
            this.Controls.Add(this.HrsWork_TextBox);
            this.Controls.Add(this.EmpID_TextBox);
            this.Controls.Add(this.EmpName_TextBox);
            this.Controls.Add(this.SalesBonus_Label);
            this.Controls.Add(this.TotSales_Label);
            this.Controls.Add(this.HrsWork_Label);
            this.Controls.Add(this.EmpID_Label);
            this.Controls.Add(this.EmpName_Label);
            this.Name = "Sales_BonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.Lang_GroupBox.ResumeLayout(false);
            this.Lang_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmpName_Label;
        private System.Windows.Forms.RadioButton Eng_RadioBtn;
        private System.Windows.Forms.RadioButton FrRadio_Btn;
        private System.Windows.Forms.Label EmpID_Label;
        private System.Windows.Forms.Label HrsWork_Label;
        private System.Windows.Forms.Label TotSales_Label;
        private System.Windows.Forms.Label SalesBonus_Label;
        private System.Windows.Forms.TextBox EmpName_TextBox;
        private System.Windows.Forms.TextBox EmpID_TextBox;
        private System.Windows.Forms.TextBox HrsWork_TextBox;
        private System.Windows.Forms.TextBox TotSales_TextBox;
        private System.Windows.Forms.TextBox SalesBonus_TextBox;
        private System.Windows.Forms.Button Cal_Btn;
        private System.Windows.Forms.Button Print_Btn;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.GroupBox Lang_GroupBox;
        private System.Windows.Forms.RadioButton HinRadio_Btn;
    }
}

