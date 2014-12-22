namespace DeckCreator
{
    partial class CardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbCardImage = new System.Windows.Forms.PictureBox();
            this.lblCardName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCardImage
            // 
            this.pcbCardImage.Location = new System.Drawing.Point(4, 4);
            this.pcbCardImage.Name = "pcbCardImage";
            this.pcbCardImage.Size = new System.Drawing.Size(189, 253);
            this.pcbCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCardImage.TabIndex = 0;
            this.pcbCardImage.TabStop = false;
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCardName.Location = new System.Drawing.Point(4, 260);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(106, 25);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "metroLabel1";
            this.lblCardName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.pcbCardImage);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(198, 289);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCardImage;
        private MetroFramework.Controls.MetroLabel lblCardName;
    }
}
