namespace aplikacijaLAB
{
    partial class FrmGlavna
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
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.lblPolumjer = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.lstRezultati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(186, 160);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 0;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(186, 189);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(75, 23);
            this.btnOcisti.TabIndex = 1;
            this.btnOcisti.Text = "Ocisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(66, 49);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(96, 20);
            this.txtPolumjer.TabIndex = 2;
            this.txtPolumjer.Text = "0,00";
            this.txtPolumjer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(66, 89);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(99, 20);
            this.txtPovrsina.TabIndex = 3;
            this.txtPovrsina.Text = "0,00";
            this.txtPovrsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(66, 128);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.Size = new System.Drawing.Size(96, 20);
            this.txtOpseg.TabIndex = 4;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPolumjer
            // 
            this.lblPolumjer.AutoSize = true;
            this.lblPolumjer.Location = new System.Drawing.Point(13, 52);
            this.lblPolumjer.Name = "lblPolumjer";
            this.lblPolumjer.Size = new System.Drawing.Size(50, 13);
            this.lblPolumjer.TabIndex = 5;
            this.lblPolumjer.Text = "Polumjer:";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(12, 92);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(51, 13);
            this.lblPovrsina.TabIndex = 6;
            this.lblPovrsina.Text = "Povrsina:";
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Location = new System.Drawing.Point(12, 131);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(41, 13);
            this.lblOpseg.TabIndex = 7;
            this.lblOpseg.Text = "Opseg:";
            // 
            // lstRezultati
            // 
            this.lstRezultati.FormattingEnabled = true;
            this.lstRezultati.Location = new System.Drawing.Point(168, 49);
            this.lstRezultati.Name = "lstRezultati";
            this.lstRezultati.Size = new System.Drawing.Size(104, 95);
            this.lstRezultati.TabIndex = 8;
            this.lstRezultati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRezultati_MouseDoubleClick);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.lstRezultati);
            this.Controls.Add(this.lblOpseg);
            this.Controls.Add(this.lblPovrsina);
            this.Controls.Add(this.lblPolumjer);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnIzracunaj);
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Froma glavne aplikacije";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.Label lblPolumjer;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.ListBox lstRezultati;
    }
}

