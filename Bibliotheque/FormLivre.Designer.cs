namespace Bibliotheque
{
    partial class FormLivre
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
            System.Windows.Forms.Label codeLLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label auteurLabel;
            System.Windows.Forms.Label nbExemplaireLabel;
            System.Windows.Forms.Label codeThLabel;
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRech = new System.Windows.Forms.TextBox();
            this.codeLTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.nbExemplaireTextBox = new System.Windows.Forms.TextBox();
            this.codeThComboBox = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            codeLLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            auteurLabel = new System.Windows.Forms.Label();
            nbExemplaireLabel = new System.Windows.Forms.Label();
            codeThLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 13);
            label1.TabIndex = 26;
            label1.Text = "Code L:";
            // 
            // codeLLabel
            // 
            codeLLabel.AutoSize = true;
            codeLLabel.Location = new System.Drawing.Point(126, 84);
            codeLLabel.Name = "codeLLabel";
            codeLLabel.Size = new System.Drawing.Size(44, 13);
            codeLLabel.TabIndex = 50;
            codeLLabel.Text = "Code L:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(126, 110);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(31, 13);
            titreLabel.TabIndex = 52;
            titreLabel.Text = "Titre:";
            // 
            // auteurLabel
            // 
            auteurLabel.AutoSize = true;
            auteurLabel.Location = new System.Drawing.Point(126, 136);
            auteurLabel.Name = "auteurLabel";
            auteurLabel.Size = new System.Drawing.Size(41, 13);
            auteurLabel.TabIndex = 54;
            auteurLabel.Text = "Auteur:";
            // 
            // nbExemplaireLabel
            // 
            nbExemplaireLabel.AutoSize = true;
            nbExemplaireLabel.Location = new System.Drawing.Point(126, 162);
            nbExemplaireLabel.Name = "nbExemplaireLabel";
            nbExemplaireLabel.Size = new System.Drawing.Size(78, 13);
            nbExemplaireLabel.TabIndex = 56;
            nbExemplaireLabel.Text = "Nb Exemplaire:";
            // 
            // codeThLabel
            // 
            codeThLabel.AutoSize = true;
            codeThLabel.Location = new System.Drawing.Point(126, 188);
            codeThLabel.Name = "codeThLabel";
            codeThLabel.Size = new System.Drawing.Size(51, 13);
            codeThLabel.TabIndex = 58;
            codeThLabel.Text = "Code Th:";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(106, 284);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(36, 23);
            this.btnfirst.TabIndex = 64;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(166, 284);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(36, 23);
            this.btnprevious.TabIndex = 63;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(286, 284);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(36, 23);
            this.btnlast.TabIndex = 62;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(226, 284);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(36, 23);
            this.btnnext.TabIndex = 61;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtRech);
            this.groupBox1.Location = new System.Drawing.Point(342, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 75);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(95, 19);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 20;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtRech
            // 
            this.txtRech.Location = new System.Drawing.Point(83, 48);
            this.txtRech.Name = "txtRech";
            this.txtRech.Size = new System.Drawing.Size(87, 20);
            this.txtRech.TabIndex = 27;
            // 
            // codeLTextBox
            // 
            this.codeLTextBox.Location = new System.Drawing.Point(210, 81);
            this.codeLTextBox.Name = "codeLTextBox";
            this.codeLTextBox.Size = new System.Drawing.Size(152, 20);
            this.codeLTextBox.TabIndex = 51;
            // 
            // titreTextBox
            // 
            this.titreTextBox.Location = new System.Drawing.Point(210, 107);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(152, 20);
            this.titreTextBox.TabIndex = 53;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.Location = new System.Drawing.Point(210, 133);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(152, 20);
            this.auteurTextBox.TabIndex = 55;
            // 
            // nbExemplaireTextBox
            // 
            this.nbExemplaireTextBox.Location = new System.Drawing.Point(210, 159);
            this.nbExemplaireTextBox.Name = "nbExemplaireTextBox";
            this.nbExemplaireTextBox.Size = new System.Drawing.Size(152, 20);
            this.nbExemplaireTextBox.TabIndex = 57;
            // 
            // codeThComboBox
            // 
            this.codeThComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeThComboBox.FormattingEnabled = true;
            this.codeThComboBox.Location = new System.Drawing.Point(210, 185);
            this.codeThComboBox.Name = "codeThComboBox";
            this.codeThComboBox.Size = new System.Drawing.Size(152, 21);
            this.codeThComboBox.TabIndex = 59;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(101, 235);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 49;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(450, 179);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 48;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(450, 138);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 47;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(450, 97);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 46;
            this.btnajouter.Text = "Nouveau";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // FormLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 409);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(codeLLabel);
            this.Controls.Add(this.codeLTextBox);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreTextBox);
            this.Controls.Add(auteurLabel);
            this.Controls.Add(this.auteurTextBox);
            this.Controls.Add(nbExemplaireLabel);
            this.Controls.Add(this.nbExemplaireTextBox);
            this.Controls.Add(codeThLabel);
            this.Controls.Add(this.codeThComboBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnajouter);
            this.Name = "FormLivre";
            this.Text = "Livre";
            this.Load += new System.EventHandler(this.FormLivre_Load);
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
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRech;
        private System.Windows.Forms.TextBox codeLTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox auteurTextBox;
        private System.Windows.Forms.TextBox nbExemplaireTextBox;
        private System.Windows.Forms.ComboBox codeThComboBox;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnajouter;
    }
}