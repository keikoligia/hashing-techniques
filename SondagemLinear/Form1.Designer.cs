
namespace SondagemLinear
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListagemHash = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemHash)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListagemHash
            // 
            this.dgvListagemHash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListagemHash.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListagemHash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagemHash.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListagemHash.Location = new System.Drawing.Point(12, 140);
            this.dgvListagemHash.Name = "dgvListagemHash";
            this.dgvListagemHash.RowHeadersWidth = 51;
            this.dgvListagemHash.RowTemplate.Height = 25;
            this.dgvListagemHash.Size = new System.Drawing.Size(776, 298);
            this.dgvListagemHash.TabIndex = 0;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(156, 96);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(72, 26);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(245, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(329, 96);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(65, 26);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chave:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(91, 40);
            this.txtChave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(110, 23);
            this.txtChave.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(347, 42);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(110, 23);
            this.txtNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pessoa: ";
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "dlgAbrir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvListagemHash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemHash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListagemHash;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

