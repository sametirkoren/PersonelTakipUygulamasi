namespace PersonelTakipUygulamasi.Forms
{
    partial class FrmGiris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnSQLite = new System.Windows.Forms.RadioButton();
            this.rdBtnSqlServer = new System.Windows.Forms.RadioButton();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.rdBtnSqlServer);
            this.panel1.Controls.Add(this.rdBtnSQLite);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 279);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL TAKİP UYGULAMASI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtnSQLite
            // 
            this.rdBtnSQLite.AutoSize = true;
            this.rdBtnSQLite.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnSQLite.Location = new System.Drawing.Point(161, 135);
            this.rdBtnSQLite.Name = "rdBtnSQLite";
            this.rdBtnSQLite.Size = new System.Drawing.Size(74, 23);
            this.rdBtnSQLite.TabIndex = 1;
            this.rdBtnSQLite.TabStop = true;
            this.rdBtnSQLite.Text = "SQLite";
            this.rdBtnSQLite.UseVisualStyleBackColor = true;
            this.rdBtnSQLite.CheckedChanged += new System.EventHandler(this.rdBtnSQLite_CheckedChanged);
            // 
            // rdBtnSqlServer
            // 
            this.rdBtnSqlServer.AutoSize = true;
            this.rdBtnSqlServer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnSqlServer.Location = new System.Drawing.Point(291, 135);
            this.rdBtnSqlServer.Name = "rdBtnSqlServer";
            this.rdBtnSqlServer.Size = new System.Drawing.Size(99, 23);
            this.rdBtnSqlServer.TabIndex = 2;
            this.rdBtnSqlServer.TabStop = true;
            this.rdBtnSqlServer.Text = "Sql Server";
            this.rdBtnSqlServer.UseVisualStyleBackColor = true;
            this.rdBtnSqlServer.CheckedChanged += new System.EventHandler(this.rdBtnSqlServer_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(119, 164);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(286, 37);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(119, 207);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(286, 37);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(528, 304);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.RadioButton rdBtnSqlServer;
        private System.Windows.Forms.RadioButton rdBtnSQLite;
        private System.Windows.Forms.Label label1;
    }
}