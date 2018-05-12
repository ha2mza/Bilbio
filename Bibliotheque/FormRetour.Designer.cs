namespace Bibliotheque
{
    partial class FormRetour
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
            System.Windows.Forms.Label dateretourLabel;
            this.label3 = new System.Windows.Forms.Label();
            this.txtnomAdr = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.retourDataGridView = new System.Windows.Forms.DataGridView();
            this.codeAComboBox = new System.Windows.Forms.ComboBox();
            this.dateretourDateTimePicker = new System.Windows.Forms.DateTimePicker();
            codeALabel = new System.Windows.Forms.Label();
            dateretourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retourDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeALabel
            // 
            codeALabel.AutoSize = true;
            codeALabel.Location = new System.Drawing.Point(43, 38);
            codeALabel.Name = "codeALabel";
            codeALabel.Size = new System.Drawing.Size(44, 13);
            codeALabel.TabIndex = 50;
            codeALabel.Text = "code A:";
            // 
            // dateretourLabel
            // 
            dateretourLabel.AutoSize = true;
            dateretourLabel.Location = new System.Drawing.Point(407, 38);
            dateretourLabel.Name = "dateretourLabel";
            dateretourLabel.Size = new System.Drawing.Size(58, 13);
            dateretourLabel.TabIndex = 52;
            dateretourLabel.Text = "dateretour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Emprunts déja existant de date Retour : ";
            this.label3.Visible = false;
            // 
            // txtnomAdr
            // 
            this.txtnomAdr.Location = new System.Drawing.Point(118, 62);
            this.txtnomAdr.Name = "txtnomAdr";
            this.txtnomAdr.Size = new System.Drawing.Size(123, 20);
            this.txtnomAdr.TabIndex = 56;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(410, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Enregister";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // retourDataGridView
            // 
            this.retourDataGridView.AllowUserToAddRows = false;
            this.retourDataGridView.AllowUserToDeleteRows = false;
            this.retourDataGridView.AllowUserToResizeColumns = false;
            this.retourDataGridView.AllowUserToResizeRows = false;
            this.retourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retourDataGridView.Location = new System.Drawing.Point(31, 117);
            this.retourDataGridView.Name = "retourDataGridView";
            this.retourDataGridView.ReadOnly = true;
            this.retourDataGridView.RowHeadersVisible = false;
            this.retourDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.retourDataGridView.Size = new System.Drawing.Size(457, 220);
            this.retourDataGridView.TabIndex = 54;
            // 
            // codeAComboBox
            // 
            this.codeAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeAComboBox.FormattingEnabled = true;
            this.codeAComboBox.Location = new System.Drawing.Point(118, 35);
            this.codeAComboBox.Name = "codeAComboBox";
            this.codeAComboBox.Size = new System.Drawing.Size(123, 21);
            this.codeAComboBox.TabIndex = 51;
            this.codeAComboBox.SelectedIndexChanged += new System.EventHandler(this.codeAComboBox_SelectedIndexChanged);
            // 
            // dateretourDateTimePicker
            // 
            this.dateretourDateTimePicker.Location = new System.Drawing.Point(410, 54);
            this.dateretourDateTimePicker.Name = "dateretourDateTimePicker";
            this.dateretourDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.dateretourDateTimePicker.TabIndex = 53;
            // 
            // FormRetour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomAdr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.retourDataGridView);
            this.Controls.Add(codeALabel);
            this.Controls.Add(this.codeAComboBox);
            this.Controls.Add(dateretourLabel);
            this.Controls.Add(this.dateretourDateTimePicker);
            this.Name = "FormRetour";
            this.Text = "FormRetour";
            ((System.ComponentModel.ISupportInitialize)(this.retourDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnomAdr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView retourDataGridView;
        private System.Windows.Forms.ComboBox codeAComboBox;
        private System.Windows.Forms.DateTimePicker dateretourDateTimePicker;
    }
}