namespace motor_aposta_win.Login
{
    partial class frm_login
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
            components = new System.ComponentModel.Container();
            lbl_email = new Label();
            lbl_senha = new Label();
            txt_email = new TextBox();
            txt_senha = new TextBox();
            btn_logar = new Button();
            btn_sair = new Button();
            errorProvider1 = new ErrorProvider(components);
            lbl_tipo_jogo = new Label();
            cbo_tipo_jogo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(29, 53);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(52, 20);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "E-mail";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(31, 106);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(49, 20);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(87, 50);
            txt_email.MaxLength = 100;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(393, 27);
            txt_email.TabIndex = 2;
            txt_email.Text = "t.souza.1982@gmail.com";
            txt_email.Validating += txt_email_Validating;
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Location = new Point(86, 103);
            txt_senha.MaxLength = 30;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(394, 27);
            txt_senha.TabIndex = 3;
            txt_senha.Text = "teste";
            txt_senha.Validating += txt_senha_Validating;
            // 
            // btn_logar
            // 
            btn_logar.BackColor = Color.Lime;
            btn_logar.FlatStyle = FlatStyle.Flat;
            btn_logar.Location = new Point(271, 216);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(94, 43);
            btn_logar.TabIndex = 4;
            btn_logar.Text = "Logar";
            btn_logar.UseVisualStyleBackColor = false;
            btn_logar.Click += btn_logar_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.FromArgb(255, 128, 128);
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.ForeColor = Color.Black;
            btn_sair.Location = new Point(386, 216);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(94, 43);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbl_tipo_jogo
            // 
            lbl_tipo_jogo.AutoSize = true;
            lbl_tipo_jogo.Location = new Point(31, 154);
            lbl_tipo_jogo.Name = "lbl_tipo_jogo";
            lbl_tipo_jogo.Size = new Size(41, 20);
            lbl_tipo_jogo.TabIndex = 6;
            lbl_tipo_jogo.Text = "Jogo";
            // 
            // cbo_tipo_jogo
            // 
            cbo_tipo_jogo.FormattingEnabled = true;
            cbo_tipo_jogo.Location = new Point(86, 151);
            cbo_tipo_jogo.Name = "cbo_tipo_jogo";
            cbo_tipo_jogo.Size = new Size(226, 28);
            cbo_tipo_jogo.TabIndex = 7;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 293);
            Controls.Add(cbo_tipo_jogo);
            Controls.Add(lbl_tipo_jogo);
            Controls.Add(btn_sair);
            Controls.Add(btn_logar);
            Controls.Add(txt_senha);
            Controls.Add(txt_email);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_email);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            FormClosed += frm_login_FormClosed;
            Load += frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_email;
        private Label lbl_senha;
        private TextBox txt_email;
        private TextBox txt_senha;
        private Button btn_logar;
        private Button btn_sair;
        private ErrorProvider errorProvider1;
        private Label lbl_tipo_jogo;
        private ComboBox cbo_tipo_jogo;
    }
}