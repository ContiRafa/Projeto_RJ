namespace Projeto_RJ
{
    partial class frm_modalCadastro
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
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modalCadastro));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_sigla = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.lbl_grupo_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.picture_imagemUsuario = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_upload_picture = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_excluir_foto = new System.Windows.Forms.Button();
            this.txt_campo_nome = new System.Windows.Forms.TextBox();
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagemUsuario)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(43, 324);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(45, 16);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // lbl_sigla
            // 
            this.lbl_sigla.AutoSize = true;
            this.lbl_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sigla.Location = new System.Drawing.Point(566, 118);
            this.lbl_sigla.Name = "lbl_sigla";
            this.lbl_sigla.Size = new System.Drawing.Size(43, 16);
            this.lbl_sigla.TabIndex = 1;
            this.lbl_sigla.Text = "Sigla";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(42, 215);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 16);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.AutoSize = true;
            this.lbl_nome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_usuario.Location = new System.Drawing.Point(43, 118);
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            this.lbl_nome_usuario.Size = new System.Drawing.Size(48, 16);
            this.lbl_nome_usuario.TabIndex = 3;
            this.lbl_nome_usuario.Text = "Nome";
            // 
            // lbl_grupo_usuario
            // 
            this.lbl_grupo_usuario.AutoSize = true;
            this.lbl_grupo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo_usuario.Location = new System.Drawing.Point(566, 215);
            this.lbl_grupo_usuario.Name = "lbl_grupo_usuario";
            this.lbl_grupo_usuario.Size = new System.Drawing.Size(126, 16);
            this.lbl_grupo_usuario.TabIndex = 4;
            this.lbl_grupo_usuario.Text = "Grupo de usuário";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(431, 481);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(51, 16);
            this.lbl_senha.TabIndex = 5;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(431, 510);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(38, 16);
            this.lbl_foto.TabIndex = 6;
            this.lbl_foto.Text = "Foto";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Controls.Add(dateTimePicker2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 85);
            this.panel1.TabIndex = 9;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(9, 29);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(316, 29);
            this.lbl_name_header.TabIndex = 5;
            this.lbl_name_header.Text = "CADASTRO DE USUÁRIO";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(1028, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(222, 32);
            dateTimePicker2.TabIndex = 6;
            // 
            // picture_imagemUsuario
            // 
            this.picture_imagemUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_imagemUsuario.BackgroundImage")));
            this.picture_imagemUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_imagemUsuario.Location = new System.Drawing.Point(898, 118);
            this.picture_imagemUsuario.Name = "picture_imagemUsuario";
            this.picture_imagemUsuario.Size = new System.Drawing.Size(200, 200);
            this.picture_imagemUsuario.TabIndex = 10;
            this.picture_imagemUsuario.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_excluir_foto);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_upload_picture);
            this.panel2.Location = new System.Drawing.Point(898, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 38);
            this.panel2.TabIndex = 13;
            // 
            // btn_upload_picture
            // 
            this.btn_upload_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_upload_picture.BackgroundImage")));
            this.btn_upload_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_upload_picture.Location = new System.Drawing.Point(31, 3);
            this.btn_upload_picture.Name = "btn_upload_picture";
            this.btn_upload_picture.Size = new System.Drawing.Size(30, 32);
            this.btn_upload_picture.TabIndex = 12;
            this.btn_upload_picture.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(87, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 32);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_excluir_foto
            // 
            this.btn_excluir_foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir_foto.BackgroundImage")));
            this.btn_excluir_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excluir_foto.Location = new System.Drawing.Point(142, 3);
            this.btn_excluir_foto.Name = "btn_excluir_foto";
            this.btn_excluir_foto.Size = new System.Drawing.Size(29, 32);
            this.btn_excluir_foto.TabIndex = 14;
            this.btn_excluir_foto.UseVisualStyleBackColor = true;
            // 
            // txt_campo_nome
            // 
            this.txt_campo_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_campo_nome.Location = new System.Drawing.Point(46, 356);
            this.txt_campo_nome.Name = "txt_campo_nome";
            this.txt_campo_nome.Size = new System.Drawing.Size(424, 29);
            this.txt_campo_nome.TabIndex = 14;
            // 
            // txt_sigla
            // 
            this.txt_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sigla.Location = new System.Drawing.Point(569, 150);
            this.txt_sigla.Name = "txt_sigla";
            this.txt_sigla.Size = new System.Drawing.Size(248, 29);
            this.txt_sigla.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(45, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 29);
            this.textBox1.TabIndex = 16;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(45, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(424, 29);
            this.txt_nome.TabIndex = 17;
            // 
            // frm_modalCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_sigla);
            this.Controls.Add(this.txt_campo_nome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picture_imagemUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_grupo_usuario);
            this.Controls.Add(this.lbl_nome_usuario);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_sigla);
            this.Controls.Add(this.lbl_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_modalCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Exames";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imagemUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_sigla;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Label lbl_grupo_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.PictureBox picture_imagemUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_upload_picture;
        private System.Windows.Forms.Button btn_excluir_foto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_campo_nome;
        private System.Windows.Forms.TextBox txt_sigla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_nome;
    }
}