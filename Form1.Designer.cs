namespace KolekcijeKategorijeVozila
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrojKotaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 29);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtBrojKotaca
            // 
            this.txtBrojKotaca.Location = new System.Drawing.Point(12, 107);
            this.txtBrojKotaca.Name = "txtBrojKotaca";
            this.txtBrojKotaca.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKotaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina Proizvodnje ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj Kotaca ";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(12, 133);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(100, 23);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(12, 357);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(100, 23);
            this.btnObradi.TabIndex = 7;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(12, 415);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(100, 23);
            this.btnIspis.TabIndex = 8;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(141, 29);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(647, 380);
            this.txtIspis.TabIndex = 9;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.FormattingEnabled = true;
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(12, 68);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(102, 21);
            this.txtGodinaProizvodnje.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojKotaca);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrojKotaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.ComboBox txtGodinaProizvodnje;
    }
}

