namespace Bibliotheque
{
    partial class FormTheme
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label codethLabel;
            System.Windows.Forms.Label intituleThLabel;
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRech = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.codethTextBox = new System.Windows.Forms.TextBox();
            this.intituleThTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            codethLabel = new System.Windows.Forms.Label();
            intituleThLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(24, 141);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(36, 23);
            this.btnfirst.TabIndex = 62;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(84, 141);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(36, 23);
            this.btnprevious.TabIndex = 61;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(204, 141);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(36, 23);
            this.btnlast.TabIndex = 60;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(144, 141);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(36, 23);
            this.btnnext.TabIndex = 59;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtRech);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Location = new System.Drawing.Point(253, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 87);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 13);
            label1.TabIndex = 31;
            label1.Text = "Code Théme";
            // 
            // txtRech
            // 
            this.txtRech.Location = new System.Drawing.Point(75, 53);
            this.txtRech.Name = "txtRech";
            this.txtRech.Size = new System.Drawing.Size(84, 20);
            this.txtRech.TabIndex = 32;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(84, 24);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 27;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(17, 102);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 57;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(253, 102);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 56;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(253, 65);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 55;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(253, 28);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 54;
            this.btnajouter.Text = "Nouveau";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // codethLabel
            // 
            codethLabel.AutoSize = true;
            codethLabel.Location = new System.Drawing.Point(17, 33);
            codethLabel.Name = "codethLabel";
            codethLabel.Size = new System.Drawing.Size(68, 13);
            codethLabel.TabIndex = 50;
            codethLabel.Text = "Code Théme";
            // 
            // codethTextBox
            // 
            this.codethTextBox.Location = new System.Drawing.Point(99, 30);
            this.codethTextBox.Name = "codethTextBox";
            this.codethTextBox.Size = new System.Drawing.Size(100, 20);
            this.codethTextBox.TabIndex = 51;
            // 
            // intituleThLabel
            // 
            intituleThLabel.AutoSize = true;
            intituleThLabel.Location = new System.Drawing.Point(17, 59);
            intituleThLabel.Name = "intituleThLabel";
            intituleThLabel.Size = new System.Drawing.Size(77, 13);
            intituleThLabel.TabIndex = 52;
            intituleThLabel.Text = "Intitulé Théme:";
            // 
            // intituleThTextBox
            // 
            this.intituleThTextBox.Location = new System.Drawing.Point(99, 56);
            this.intituleThTextBox.Name = "intituleThTextBox";
            this.intituleThTextBox.Size = new System.Drawing.Size(100, 20);
            this.intituleThTextBox.TabIndex = 53;
            // 
            // FormTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 257);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(codethLabel);
            this.Controls.Add(this.codethTextBox);
            this.Controls.Add(intituleThLabel);
            this.Controls.Add(this.intituleThTextBox);
            this.Name = "FormTheme";
            this.Text = "FormTheme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRech;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox codethTextBox;
        private System.Windows.Forms.TextBox intituleThTextBox;
    }
}