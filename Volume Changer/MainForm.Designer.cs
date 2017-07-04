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
            this.PUBGMainText = new System.Windows.Forms.Label();
            this.PUBGHotKey1Text = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PUBGMainText
            // 
            this.PUBGMainText.AutoSize = true;
            this.PUBGMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUBGMainText.Location = new System.Drawing.Point(13, 13);
            this.PUBGMainText.Name = "PUBGMainText";
            this.PUBGMainText.Size = new System.Drawing.Size(111, 16);
            this.PUBGMainText.TabIndex = 0;
            this.PUBGMainText.Text = "PUBG Hotkeys";
            // 
            // PUBGHotKey1Text
            // 
            this.PUBGHotKey1Text.AutoSize = true;
            this.PUBGHotKey1Text.Location = new System.Drawing.Point(130, 15);
            this.PUBGHotKey1Text.Name = "PUBGHotKey1Text";
            this.PUBGHotKey1Text.Size = new System.Drawing.Size(23, 13);
            this.PUBGHotKey1Text.TabIndex = 1;
            this.PUBGHotKey1Text.Text = "null";
            // 
            // logBox
            // 
            this.logBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logBox.Enabled = false;
            this.logBox.Location = new System.Drawing.Point(12, 32);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(403, 113);
            this.logBox.TabIndex = 3;
            this.logBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 157);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.PUBGHotKey1Text);
            this.Controls.Add(this.PUBGMainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PUBGMainText;
        private System.Windows.Forms.Label PUBGHotKey1Text;
        private System.Windows.Forms.RichTextBox logBox;
    }
}

