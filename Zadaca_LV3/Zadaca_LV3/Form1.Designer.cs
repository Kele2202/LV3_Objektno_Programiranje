namespace Zadaca_LV3
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bFont = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(13, 13);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(498, 250);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bFont
            // 
            this.bFont.Location = new System.Drawing.Point(12, 269);
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(75, 23);
            this.bFont.TabIndex = 1;
            this.bFont.Text = "Font";
            this.bFont.UseVisualStyleBackColor = true;
            this.bFont.Click += new System.EventHandler(this.bFont_Click);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(93, 269);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(75, 23);
            this.bColor.TabIndex = 2;
            this.bColor.Text = "Boja";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(174, 269);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 3;
            this.bOpen.Text = "Otvori";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(255, 269);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Spremi";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 304);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.bFont);
            this.Controls.Add(this.rtbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bFont;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bSave;
    }
}

