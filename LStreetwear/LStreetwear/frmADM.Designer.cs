
namespace LStreetwear
{
    partial class frmADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADM));
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblNomprod = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblDataRepo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.dtpDataRepo = new System.Windows.Forms.DateTimePicker();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.gpbCrud1 = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gpbCrud2 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbCrud1.SuspendLayout();
            this.gpbCrud2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(126, 129);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(151, 18);
            this.lblCodProd.TabIndex = 0;
            this.lblCodProd.Text = "Código do Produto";
            // 
            // lblNomprod
            // 
            this.lblNomprod.AutoSize = true;
            this.lblNomprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomprod.Location = new System.Drawing.Point(133, 190);
            this.lblNomprod.Name = "lblNomprod";
            this.lblNomprod.Size = new System.Drawing.Size(142, 18);
            this.lblNomprod.TabIndex = 1;
            this.lblNomprod.Text = "Nome do Produto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(204, 248);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 18);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(177, 304);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(93, 18);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 4;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(565, 193);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(78, 18);
            this.lblTamanho.TabIndex = 5;
            this.lblTamanho.Text = "Tamanho";
            // 
            // lblDataRepo
            // 
            this.lblDataRepo.AutoSize = true;
            this.lblDataRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRepo.Location = new System.Drawing.Point(491, 245);
            this.lblDataRepo.Name = "lblDataRepo";
            this.lblDataRepo.Size = new System.Drawing.Size(152, 18);
            this.lblDataRepo.TabIndex = 6;
            this.lblDataRepo.Text = "Data de Reposição";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(588, 304);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(53, 18);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço";
            // 
            // dtpDataRepo
            // 
            this.dtpDataRepo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataRepo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRepo.Location = new System.Drawing.Point(642, 245);
            this.dtpDataRepo.Name = "dtpDataRepo";
            this.dtpDataRepo.Size = new System.Drawing.Size(78, 20);
            this.dtpDataRepo.TabIndex = 8;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Location = new System.Drawing.Point(283, 129);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(78, 20);
            this.txtCodProd.TabIndex = 9;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(281, 194);
            this.txtNomeProd.MaxLength = 100;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(206, 20);
            this.txtNomeProd.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(283, 301);
            this.txtQuantidade.MaxLength = 6;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(78, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(642, 191);
            this.txtTamanho.MaxLength = 2;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(78, 20);
            this.txtTamanho.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(642, 301);
            this.txtPreco.MaxLength = 8;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(78, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(283, 246);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(206, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // gpbCrud1
            // 
            this.gpbCrud1.Controls.Add(this.btnNovo);
            this.gpbCrud1.Controls.Add(this.btnAlterar);
            this.gpbCrud1.Controls.Add(this.btnAdicionar);
            this.gpbCrud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCrud1.Location = new System.Drawing.Point(9, 103);
            this.gpbCrud1.Name = "gpbCrud1";
            this.gpbCrud1.Size = new System.Drawing.Size(111, 287);
            this.gpbCrud1.TabIndex = 1;
            this.gpbCrud1.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAlterar.Location = new System.Drawing.Point(6, 201);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 64);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 107);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(85, 64);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gpbCrud2
            // 
            this.gpbCrud2.Controls.Add(this.btnDeletar);
            this.gpbCrud2.Controls.Add(this.btnPesquisar);
            this.gpbCrud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCrud2.Location = new System.Drawing.Point(757, 103);
            this.gpbCrud2.Name = "gpbCrud2";
            this.gpbCrud2.Size = new System.Drawing.Size(111, 287);
            this.gpbCrud2.TabIndex = 10;
            this.gpbCrud2.TabStop = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeletar.Location = new System.Drawing.Point(10, 198);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(85, 64);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisar.Location = new System.Drawing.Point(10, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 64);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(25, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 37);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovo.Location = new System.Drawing.Point(6, 26);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 64);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbCrud2);
            this.Controls.Add(this.gpbCrud1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.dtpDataRepo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDataRepo);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNomprod);
            this.Controls.Add(this.lblCodProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmADM_Load);
            this.gpbCrud1.ResumeLayout(false);
            this.gpbCrud2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblNomprod;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblDataRepo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.DateTimePicker dtpDataRepo;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox gpbCrud1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gpbCrud2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
    }
}