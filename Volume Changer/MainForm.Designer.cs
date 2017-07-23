namespace Volume_Changer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.Max = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessBox = new System.Windows.Forms.TextBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShortcutText = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UseModifier = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(6, 45);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(50, 20);
            this.Min.TabIndex = 4;
            this.Min.TabStop = false;
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min.ValueChanged += new System.EventHandler(this.Min_ValueChanged);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(6, 19);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(50, 20);
            this.Max.TabIndex = 5;
            this.Max.TabStop = false;
            this.Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Max.ValueChanged += new System.EventHandler(this.Max_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min Volume";
            // 
            // ProcessBox
            // 
            this.ProcessBox.Location = new System.Drawing.Point(6, 18);
            this.ProcessBox.Name = "ProcessBox";
            this.ProcessBox.Size = new System.Drawing.Size(277, 20);
            this.ProcessBox.TabIndex = 8;
            this.ProcessBox.TabStop = false;
            this.ProcessBox.TextChanged += new System.EventHandler(this.ProcessBox_TextChanged);
            // 
            // ModifyButton
            // 
            this.ModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyButton.Location = new System.Drawing.Point(6, 19);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(108, 36);
            this.ModifyButton.TabIndex = 0;
            this.ModifyButton.TabStop = false;
            this.ModifyButton.Text = "&Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UseModifier);
            this.groupBox2.Controls.Add(this.ShortcutText);
            this.groupBox2.Controls.Add(this.ModifyButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Shortcut";
            // 
            // ShortcutText
            // 
            this.ShortcutText.AutoSize = true;
            this.ShortcutText.Location = new System.Drawing.Point(120, 31);
            this.ShortcutText.Name = "ShortcutText";
            this.ShortcutText.Size = new System.Drawing.Size(47, 13);
            this.ShortcutText.TabIndex = 0;
            this.ShortcutText.Text = "Shift + T";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProcessBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 46);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Max);
            this.groupBox4.Controls.Add(this.Min);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 73);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volume";
            // 
            // UseModifier
            // 
            this.UseModifier.AutoSize = true;
            this.UseModifier.Location = new System.Drawing.Point(7, 62);
            this.UseModifier.Name = "UseModifier";
            this.UseModifier.Size = new System.Drawing.Size(111, 17);
            this.UseModifier.TabIndex = 1;
            this.UseModifier.Text = "Use Modifier Keys";
            this.UseModifier.UseVisualStyleBackColor = true;
            this.UseModifier.CheckedChanged += new System.EventHandler(this.UseModifier_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(313, 239);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume Changer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Min;
        private System.Windows.Forms.NumericUpDown Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProcessBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button ModifyButton;
        public System.Windows.Forms.Label ShortcutText;
        private System.Windows.Forms.CheckBox UseModifier;
    }
}

