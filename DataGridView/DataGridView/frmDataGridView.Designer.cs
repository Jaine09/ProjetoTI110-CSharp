
namespace DataGridView
{
    partial class frmDataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.email,
            this.cpf,
            this.telcel});
            this.dataGridView1.Location = new System.Drawing.Point(39, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigo.HeaderText = "Código";
            this.codigo.MaxInputLength = 10;
            this.codigo.Name = "codigo";
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome.HeaderText = "Nome";
            this.nome.MaxInputLength = 100;
            this.nome.Name = "nome";
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome.Width = 200;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.HeaderText = "E-mail";
            this.email.MaxInputLength = 100;
            this.email.Name = "email";
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email.Width = 200;
            // 
            // cpf
            // 
            this.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cpf.HeaderText = "CPF";
            this.cpf.MaxInputLength = 14;
            this.cpf.Name = "cpf";
            this.cpf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // telcel
            // 
            this.telcel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telcel.HeaderText = "Celular";
            this.telcel.MaxInputLength = 10;
            this.telcel.Name = "telcel";
            // 
            // frmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 635);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDataGridView";
            this.Text = "frmDataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcel;
    }
}

