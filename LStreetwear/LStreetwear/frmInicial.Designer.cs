
namespace LStreetwear
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnFuncionário = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAdm.Image")));
            this.btnAdm.Location = new System.Drawing.Point(84, 87);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(222, 221);
            this.btnAdm.TabIndex = 0;
            this.btnAdm.Text = "&ADM";
            this.btnAdm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click_1);
            // 
            // btnFuncionário
            // 
            this.btnFuncionário.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFuncionário.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionário.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionário.Image")));
            this.btnFuncionário.Location = new System.Drawing.Point(337, 87);
            this.btnFuncionário.Name = "btnFuncionário";
            this.btnFuncionário.Size = new System.Drawing.Size(222, 221);
            this.btnFuncionário.TabIndex = 1;
            this.btnFuncionário.Text = "&Funcionário";
            this.btnFuncionário.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionário.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFuncionário.UseVisualStyleBackColor = false;
            this.btnFuncionário.Click += new System.EventHandler(this.btnFuncionário_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(588, 87);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(222, 221);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "&Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(374, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 41);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFuncionário);
            this.Controls.Add(this.btnAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnFuncionário;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSair;
    }
}