namespace Bibliotheque
{
    partial class FormAdherant
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
            System.Windows.Forms.Label codeALabel;
            System.Windows.Forms.Label nomALabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label dateInscriptionLabel;
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRech = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.codeATextBox = new System.Windows.Forms.TextBox();
            this.nomATextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.dateInscriptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            codeALabel = new System.Windows.Forms.Label();
            nomALabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
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
            label1.Text = "code A:";
            // 
            // codeALabel
            // 
            codeALabel.AutoSize = true;
            codeALabel.Location = new System.Drawing.Point(69, 83);
            codeALabel.Name = "codeALabel";
            codeALabel.Size = new System.Drawing.Size(44, 13);
            codeALabel.TabIndex = 30;
            codeALabel.Text = "code A:";
            // 
            // nomALabel
            // 
            nomALabel.AutoSize = true;
            nomALabel.Location = new System.Drawing.Point(69, 109);
            nomALabel.Name = "nomALabel";
            nomALabel.Size = new System.Drawing.Size(40, 13);
            nomALabel.TabIndex = 32;
            nomALabel.Text = "nom A:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(69, 135);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(47, 13);
            adresseLabel.TabIndex = 34;
            adresseLabel.Text = "adresse:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Location = new System.Drawing.Point(69, 162);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(84, 13);
            dateInscriptionLabel.TabIndex = 36;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(66, 244);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(36, 23);
            this.btnfirst.TabIndex = 46;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(126, 244);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(36, 23);
            this.btnprevious.TabIndex = 45;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(246, 244);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(36, 23);
            this.btnlast.TabIndex = 44;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(186, 244);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(36, 23);
            this.btnnext.TabIndex = 43;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtRech);
            this.groupBox1.Location = new System.Drawing.Point(315, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 75);
            this.groupBox1.TabIndex = 42;
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
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(72, 192);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 41;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(410, 162);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 40;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(410, 119);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 39;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(410, 73);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 38;
            this.btnajouter.Text = "Nouveau";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // codeATextBox
            // 
            this.codeATextBox.Location = new System.Drawing.Point(159, 80);
            this.codeATextBox.Name = "codeATextBox";
            this.codeATextBox.Size = new System.Drawing.Size(200, 20);
            this.codeATextBox.TabIndex = 31;
            // 
            // nomATextBox
            // 
            this.nomATextBox.Location = new System.Drawing.Point(159, 106);
            this.nomATextBox.Name = "nomATextBox";
            this.nomATextBox.Size = new System.Drawing.Size(200, 20);
            this.nomATextBox.TabIndex = 33;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.Location = new System.Drawing.Point(159, 132);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresseTextBox.TabIndex = 35;
            // 
            // dateInscriptionDateTimePicker
            // 
            this.dateInscriptionDateTimePicker.Location = new System.Drawing.Point(159, 158);
            this.dateInscriptionDateTimePicker.Name = "dateInscriptionDateTimePicker";
            this.dateInscriptionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateInscriptionDateTimePicker.TabIndex = 37;
            // 
            // FormAdherant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(codeALabel);
            this.Controls.Add(this.codeATextBox);
            this.Controls.Add(nomALabel);
            this.Controls.Add(this.nomATextBox);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.adresseTextBox);
            this.Controls.Add(dateInscriptionLabel);
            this.Controls.Add(this.dateInscriptionDateTimePicker);
            this.Name = "FormAdherant";
            this.Text = "FormAdherant";
            this.Load += new System.EventHandler(this.FormAdherant_Load);
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
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox codeATextBox;
        private System.Windows.Forms.TextBox nomATextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.DateTimePicker dateInscriptionDateTimePicker;
    }
}