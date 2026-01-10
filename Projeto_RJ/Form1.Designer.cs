namespace Projeto_RJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            this.panel2 = new System.Windows.Forms.Panel();
            this.containerImagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_header = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbl_preferencial = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lbl_preferencial);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.containerImagem);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Location = new System.Drawing.Point(654, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 835);
            this.panel2.TabIndex = 11;
            // 
            // containerImagem
            // 
            this.containerImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.containerImagem.Image = ((System.Drawing.Image)(resources.GetObject("containerImagem.Image")));
            this.containerImagem.Location = new System.Drawing.Point(0, 0);
            this.containerImagem.Name = "containerImagem";
            this.containerImagem.Size = new System.Drawing.Size(600, 200);
            this.containerImagem.TabIndex = 9;
            this.containerImagem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbl_name_header);
            this.panel1.Controls.Add(dateTimePicker2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 85);
            this.panel1.TabIndex = 10;
            // 
            // lbl_name_header
            // 
            this.lbl_name_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name_header.AutoSize = true;
            this.lbl_name_header.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name_header.Location = new System.Drawing.Point(28, 27);
            this.lbl_name_header.Name = "lbl_name_header";
            this.lbl_name_header.Size = new System.Drawing.Size(205, 29);
            this.lbl_name_header.TabIndex = 7;
            this.lbl_name_header.Text = "TOTEM VIRTUAL";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.DarkOrange;
            dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(1655, 25);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(222, 33);
            dateTimePicker2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(600, 80);
            this.button2.TabIndex = 12;
            this.button2.Text = "RETIRADA DE EXAMES";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(0, 401);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(600, 80);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "RECEPÇÃO";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // lbl_preferencial
            // 
            this.lbl_preferencial.AutoSize = true;
            this.lbl_preferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preferencial.Location = new System.Drawing.Point(3, 288);
            this.lbl_preferencial.Name = "lbl_preferencial";
            this.lbl_preferencial.Size = new System.Drawing.Size(705, 42);
            this.lbl_preferencial.TabIndex = 13;
            this.lbl_preferencial.Text = "RETIRE SUA SENHA PREFERÊNCIAL";
            this.lbl_preferencial.Click += new System.EventHandler(this.lbl_preferencial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox containerImagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name_header;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_preferencial;
        private System.Windows.Forms.Button btnIniciar;
    }
}