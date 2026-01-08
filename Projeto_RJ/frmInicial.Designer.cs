namespace Projeto_RJ
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.container_info = new System.Windows.Forms.GroupBox();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.container_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_info
            // 
            this.container_info.Controls.Add(this.lbl_name_header);
            this.container_info.Location = new System.Drawing.Point(0, 2);
            this.container_info.Name = "container_info";
            this.container_info.Size = new System.Drawing.Size(1920, 50);
            this.container_info.TabIndex = 0;
            this.container_info.TabStop = false;
            this.container_info.Text = "container_info";
            this.container_info.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Location = new System.Drawing.Point(12, 16);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(94, 13);
            this.lbl_name_header.TabIndex = 2;
            this.lbl_name_header.Text = "TOTEM VIRTUAL";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.container_info);
            this.Name = "frmInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.container_info.ResumeLayout(false);
            this.container_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox container_info;
        private System.Windows.Forms.Label lbl_name_header;
    }
}

