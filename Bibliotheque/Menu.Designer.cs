namespace Bibliotheque
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adhérentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieRetourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adhérentToolStripMenuItem,
            this.livreToolStripMenuItem,
            this.thèmeToolStripMenuItem,
            this.empruntToolStripMenuItem,
            this.saisieRetourToolStripMenuItem,
            this.enregisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adhérentToolStripMenuItem
            // 
            this.adhérentToolStripMenuItem.Name = "adhérentToolStripMenuItem";
            this.adhérentToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.adhérentToolStripMenuItem.Text = "Adhérent";
            this.adhérentToolStripMenuItem.Click += new System.EventHandler(this.adhérentToolStripMenuItem_Click);
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.livreToolStripMenuItem.Text = "Livre";
            this.livreToolStripMenuItem.Click += new System.EventHandler(this.livreToolStripMenuItem_Click);
            // 
            // thèmeToolStripMenuItem
            // 
            this.thèmeToolStripMenuItem.Name = "thèmeToolStripMenuItem";
            this.thèmeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.thèmeToolStripMenuItem.Text = "Thème";
            this.thèmeToolStripMenuItem.Click += new System.EventHandler(this.thèmeToolStripMenuItem_Click);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.empruntToolStripMenuItem.Text = "Emprunt";
            this.empruntToolStripMenuItem.Click += new System.EventHandler(this.empruntToolStripMenuItem_Click);
            // 
            // saisieRetourToolStripMenuItem
            // 
            this.saisieRetourToolStripMenuItem.Name = "saisieRetourToolStripMenuItem";
            this.saisieRetourToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.saisieRetourToolStripMenuItem.Text = "Saisie Retour";
            this.saisieRetourToolStripMenuItem.Click += new System.EventHandler(this.saisieRetourToolStripMenuItem_Click);
            // 
            // enregisterToolStripMenuItem
            // 
            this.enregisterToolStripMenuItem.Name = "enregisterToolStripMenuItem";
            this.enregisterToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.enregisterToolStripMenuItem.Text = "Enregister";
            this.enregisterToolStripMenuItem.Click += new System.EventHandler(this.enregisterToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adhérentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieRetourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregisterToolStripMenuItem;
    }
}