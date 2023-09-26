
namespace ProjetoLojaABC
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pcbSplash = new System.Windows.Forms.PictureBox();
            this.pgbCarregando = new System.Windows.Forms.ProgressBar();
            this.lblCarregando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSplash
            // 
            this.pcbSplash.Image = ((System.Drawing.Image)(resources.GetObject("pcbSplash.Image")));
            this.pcbSplash.Location = new System.Drawing.Point(236, 71);
            this.pcbSplash.Name = "pcbSplash";
            this.pcbSplash.Size = new System.Drawing.Size(285, 231);
            this.pcbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSplash.TabIndex = 0;
            this.pcbSplash.TabStop = false;
            // 
            // pgbCarregando
            // 
            this.pgbCarregando.Location = new System.Drawing.Point(236, 392);
            this.pgbCarregando.Name = "pgbCarregando";
            this.pgbCarregando.Size = new System.Drawing.Size(285, 23);
            this.pgbCarregando.TabIndex = 1;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.Location = new System.Drawing.Point(361, 342);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(35, 24);
            this.lblCarregando.TabIndex = 2;
            this.lblCarregando.Text = "0%";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.pgbCarregando);
            this.Controls.Add(this.pcbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSplash;
        private System.Windows.Forms.ProgressBar pgbCarregando;
        private System.Windows.Forms.Label lblCarregando;
    }
}