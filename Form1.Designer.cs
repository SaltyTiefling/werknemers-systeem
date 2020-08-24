namespace werknemers_systeem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWerknemerAmount = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.cbBedrijf = new System.Windows.Forms.ComboBox();
            this.txtSamenvatting = new System.Windows.Forms.TextBox();
            this.lbxWerknemers = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bedrijf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Btw Nr.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Werknemer count:";
            // 
            // lblWerknemerAmount
            // 
            this.lblWerknemerAmount.AutoSize = true;
            this.lblWerknemerAmount.Location = new System.Drawing.Point(246, 58);
            this.lblWerknemerAmount.Name = "lblWerknemerAmount";
            this.lblWerknemerAmount.Size = new System.Drawing.Size(27, 13);
            this.lblWerknemerAmount.TabIndex = 4;
            this.lblWerknemerAmount.Text = "land";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(246, 36);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(61, 13);
            this.lblBtw.TabIndex = 5;
            this.lblBtw.Text = "btwnummer";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(246, 13);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(33, 13);
            this.lblNaam.TabIndex = 6;
            this.lblNaam.Text = "naam";
            // 
            // cbBedrijf
            // 
            this.cbBedrijf.FormattingEnabled = true;
            this.cbBedrijf.Location = new System.Drawing.Point(13, 13);
            this.cbBedrijf.Name = "cbBedrijf";
            this.cbBedrijf.Size = new System.Drawing.Size(121, 21);
            this.cbBedrijf.TabIndex = 8;
            this.cbBedrijf.SelectedIndexChanged += new System.EventHandler(this.cbBedrijf_SelectedIndexChanged);
            // 
            // txtSamenvatting
            // 
            this.txtSamenvatting.Location = new System.Drawing.Point(140, 74);
            this.txtSamenvatting.Multiline = true;
            this.txtSamenvatting.Name = "txtSamenvatting";
            this.txtSamenvatting.ReadOnly = true;
            this.txtSamenvatting.Size = new System.Drawing.Size(636, 116);
            this.txtSamenvatting.TabIndex = 9;
            // 
            // lbxWerknemers
            // 
            this.lbxWerknemers.FormattingEnabled = true;
            this.lbxWerknemers.Location = new System.Drawing.Point(13, 40);
            this.lbxWerknemers.Name = "lbxWerknemers";
            this.lbxWerknemers.Size = new System.Drawing.Size(121, 121);
            this.lbxWerknemers.TabIndex = 10;
            this.lbxWerknemers.SelectedIndexChanged += new System.EventHandler(this.lbxWerknemers_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(74, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbxWerknemers);
            this.Controls.Add(this.txtSamenvatting);
            this.Controls.Add(this.cbBedrijf);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblWerknemerAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWerknemerAmount;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.ComboBox cbBedrijf;
        private System.Windows.Forms.TextBox txtSamenvatting;
        private System.Windows.Forms.ListBox lbxWerknemers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

