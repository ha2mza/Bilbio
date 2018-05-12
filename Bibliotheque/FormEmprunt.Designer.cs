namespace Bibliotheque
{
    partial class FormEmprunt
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
            System.Windows.Forms.Label codeALabel;
            System.Windows.Forms.Label date_empruntLabel;
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codethComboBox = new System.Windows.Forms.ComboBox();
            this.lstBoxLivres = new System.Windows.Forms.ListBox();
            this.txtnomAdr = new System.Windows.Forms.TextBox();
            this.codeAComboBox = new System.Windows.Forms.ComboBox();
            this.date_empruntDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.empruntDataGridView = new System.Windows.Forms.DataGridView();
            codeALabel = new System.Windows.Forms.Label();
            date_empruntLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empruntDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeALabel
            // 
            codeALabel.AutoSize = true;
            codeALabel.Location = new System.Drawing.Point(12, 38);
            codeALabel.Name = "codeALabel";
            codeALabel.Size = new System.Drawing.Size(84, 13);
            codeALabel.TabIndex = 51;
            codeALabel.Text = "Code Adhérent :";
            // 
            // date_empruntLabel
            // 
            date_empruntLabel.AutoSize = true;
            date_empruntLabel.Location = new System.Drawing.Point(583, 122);
            date_empruntLabel.Name = "date_empruntLabel";
            date_empruntLabel.Size = new System.Drawing.Size(72, 13);
            date_empruntLabel.TabIndex = 53;
            date_empruntLabel.Text = "date emprunt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Emprunts déja existant de l\'Adhérent : ";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Livres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Théme :";
            // 
            // codethComboBox
            // 
            this.codethComboBox.FormattingEnabled = true;
            this.codethComboBox.Location = new System.Drawing.Point(377, 30);
            this.codethComboBox.Name = "codethComboBox";
            this.codethComboBox.Size = new System.Drawing.Size(101, 21);
            this.codethComboBox.TabIndex = 57;
            this.codethComboBox.SelectedIndexChanged += new System.EventHandler(this.codethComboBox_SelectedIndexChanged);
            // 
            // lstBoxLivres
            // 
            this.lstBoxLivres.FormattingEnabled = true;
            this.lstBoxLivres.Location = new System.Drawing.Point(377, 83);
            this.lstBoxLivres.Name = "lstBoxLivres";
            this.lstBoxLivres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxLivres.Size = new System.Drawing.Size(159, 134);
            this.lstBoxLivres.TabIndex = 56;
            this.lstBoxLivres.SelectedIndexChanged += new System.EventHandler(this.lstBoxLivres_SelectedIndexChanged);
            // 
            // txtnomAdr
            // 
            this.txtnomAdr.Location = new System.Drawing.Point(102, 62);
            this.txtnomAdr.Name = "txtnomAdr";
            this.txtnomAdr.Size = new System.Drawing.Size(123, 20);
            this.txtnomAdr.TabIndex = 55;
            // 
            // codeAComboBox
            // 
            this.codeAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeAComboBox.FormattingEnabled = true;
            this.codeAComboBox.Location = new System.Drawing.Point(102, 35);
            this.codeAComboBox.Name = "codeAComboBox";
            this.codeAComboBox.Size = new System.Drawing.Size(123, 21);
            this.codeAComboBox.TabIndex = 52;
            this.codeAComboBox.SelectedIndexChanged += new System.EventHandler(this.codeAComboBox_SelectedIndexChanged);
            // 
            // date_empruntDateTimePicker
            // 
            this.date_empruntDateTimePicker.Location = new System.Drawing.Point(558, 138);
            this.date_empruntDateTimePicker.Name = "date_empruntDateTimePicker";
            this.date_empruntDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.date_empruntDateTimePicker.TabIndex = 54;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(586, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Enregister";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // empruntDataGridView
            // 
            this.empruntDataGridView.AllowUserToAddRows = false;
            this.empruntDataGridView.AllowUserToDeleteRows = false;
            this.empruntDataGridView.AllowUserToResizeColumns = false;
            this.empruntDataGridView.AllowUserToResizeRows = false;
            this.empruntDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empruntDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empruntDataGridView.Location = new System.Drawing.Point(12, 149);
            this.empruntDataGridView.Name = "empruntDataGridView";
            this.empruntDataGridView.ReadOnly = true;
            this.empruntDataGridView.RowHeadersVisible = false;
            this.empruntDataGridView.Size = new System.Drawing.Size(338, 191);
            this.empruntDataGridView.TabIndex = 49;
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codethComboBox);
            this.Controls.Add(this.lstBoxLivres);
            this.Controls.Add(this.txtnomAdr);
            this.Controls.Add(codeALabel);
            this.Controls.Add(this.codeAComboBox);
            this.Controls.Add(date_empruntLabel);
            this.Controls.Add(this.date_empruntDateTimePicker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.empruntDataGridView);
            this.Name = "FormEmprunt";
            this.Text = "Emprunt";
            ((System.ComponentModel.ISupportInitialize)(this.empruntDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox codethComboBox;
        private System.Windows.Forms.ListBox lstBoxLivres;
        private System.Windows.Forms.TextBox txtnomAdr;
        private System.Windows.Forms.ComboBox codeAComboBox;
        private System.Windows.Forms.DateTimePicker date_empruntDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView empruntDataGridView;
    }
}