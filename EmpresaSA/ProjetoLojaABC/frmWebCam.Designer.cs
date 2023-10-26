
namespace ProjetoLojaABC
{
    partial class frmWebCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebCam));
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cbbDispositivo = new System.Windows.Forms.ComboBox();
            this.pctCapturaImagem = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.Location = new System.Drawing.Point(85, 405);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(85, 20);
            this.lblDispositivo.TabIndex = 0;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // cbbDispositivo
            // 
            this.cbbDispositivo.FormattingEnabled = true;
            this.cbbDispositivo.Location = new System.Drawing.Point(88, 442);
            this.cbbDispositivo.Name = "cbbDispositivo";
            this.cbbDispositivo.Size = new System.Drawing.Size(161, 21);
            this.cbbDispositivo.TabIndex = 1;
            // 
            // pctCapturaImagem
            // 
            this.pctCapturaImagem.Location = new System.Drawing.Point(88, 75);
            this.pctCapturaImagem.Name = "pctCapturaImagem";
            this.pctCapturaImagem.Size = new System.Drawing.Size(305, 275);
            this.pctCapturaImagem.TabIndex = 2;
            this.pctCapturaImagem.TabStop = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(465, 75);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(126, 55);
            this.btnCaptura.TabIndex = 3;
            this.btnCaptura.Text = "Captura";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(465, 187);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 55);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(465, 295);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(126, 55);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.pctCapturaImagem);
            this.Controls.Add(this.cbbDispositivo);
            this.Controls.Add(this.lblDispositivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWebCam";
            this.Load += new System.EventHandler(this.frmWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cbbDispositivo;
        private System.Windows.Forms.PictureBox pctCapturaImagem;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnAbrir;
    }
}