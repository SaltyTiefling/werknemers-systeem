namespace werknemers_systeem
{
    partial class fNieuwewerknemer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(109, 6);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 1;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(109, 32);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(100, 20);
            this.txtLand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "land van herkomst:";
            // 
            // cbContract
            // 
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Location = new System.Drawing.Point(109, 58);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(100, 21);
            this.cbContract.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contract type:";
            // 
            // epName
            // 
            this.epName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epName.ContainerControl = this;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(133, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Voeg toe";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fNieuwewerknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 123);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbContract);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label1);
            this.Name = "fNieuwewerknemer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NieuweWerknemer";
            this.Load += new System.EventHandler(this.NieuweWerknemer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.Button btnOk;
    }
}