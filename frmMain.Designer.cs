namespace DeckCreator
{
    partial class frmMain
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tpDeck = new System.Windows.Forms.TabPage();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpSearch);
            this.metroTabControl1.Controls.Add(this.tpDeck);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(842, 515);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpSearch.Location = new System.Drawing.Point(4, 38);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(834, 473);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "Search";
            // 
            // tpDeck
            // 
            this.tpDeck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tpDeck.Location = new System.Drawing.Point(4, 38);
            this.tpDeck.Name = "tpDeck";
            this.tpDeck.Size = new System.Drawing.Size(834, 473);
            this.tpDeck.TabIndex = 1;
            this.tpDeck.Text = "Deck";
            // 
            // txtSearch
            // 
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Icon = global::DeckCreator.Properties.Resources.search_3_241;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(644, 37);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(221, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 602);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmMain";
            this.Text = "Deck Creator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpDeck;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}