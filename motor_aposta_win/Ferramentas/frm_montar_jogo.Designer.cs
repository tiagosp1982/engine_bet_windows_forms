namespace motor_aposta_win.Ferramentas
{
    partial class frm_montar_jogo
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
            grp_filtro = new GroupBox();
            cbo_concurso_fim = new ComboBox();
            cbo_concurso_inicio = new ComboBox();
            lbl_concurso_final = new Label();
            lbl_concurso_inicial = new Label();
            grpCarrinho = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btn_conferir = new Button();
            lblNumeros = new Label();
            grp_filtro.SuspendLayout();
            grpCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grp_filtro
            // 
            grp_filtro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grp_filtro.Controls.Add(cbo_concurso_fim);
            grp_filtro.Controls.Add(cbo_concurso_inicio);
            grp_filtro.Controls.Add(lbl_concurso_final);
            grp_filtro.Controls.Add(lbl_concurso_inicial);
            grp_filtro.Location = new Point(1, 2);
            grp_filtro.Name = "grp_filtro";
            grp_filtro.Size = new Size(988, 59);
            grp_filtro.TabIndex = 0;
            grp_filtro.TabStop = false;
            grp_filtro.Text = "Filtro";
            // 
            // cbo_concurso_fim
            // 
            cbo_concurso_fim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_concurso_fim.FormattingEnabled = true;
            cbo_concurso_fim.Location = new Point(538, 22);
            cbo_concurso_fim.Name = "cbo_concurso_fim";
            cbo_concurso_fim.Size = new Size(151, 28);
            cbo_concurso_fim.TabIndex = 4;
            // 
            // cbo_concurso_inicio
            // 
            cbo_concurso_inicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_concurso_inicio.FormattingEnabled = true;
            cbo_concurso_inicio.Location = new Point(200, 22);
            cbo_concurso_inicio.Name = "cbo_concurso_inicio";
            cbo_concurso_inicio.Size = new Size(151, 28);
            cbo_concurso_inicio.TabIndex = 3;
            cbo_concurso_inicio.SelectedValueChanged += cbo_concurso_inicio_SelectedValueChanged;
            // 
            // lbl_concurso_final
            // 
            lbl_concurso_final.AutoSize = true;
            lbl_concurso_final.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_concurso_final.ForeColor = Color.Blue;
            lbl_concurso_final.Location = new Point(414, 25);
            lbl_concurso_final.Name = "lbl_concurso_final";
            lbl_concurso_final.Size = new Size(118, 20);
            lbl_concurso_final.TabIndex = 2;
            lbl_concurso_final.Text = "Concurso - Fim:";
            // 
            // lbl_concurso_inicial
            // 
            lbl_concurso_inicial.AutoSize = true;
            lbl_concurso_inicial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_concurso_inicial.ForeColor = Color.Blue;
            lbl_concurso_inicial.Location = new Point(64, 25);
            lbl_concurso_inicial.Name = "lbl_concurso_inicial";
            lbl_concurso_inicial.Size = new Size(130, 20);
            lbl_concurso_inicial.TabIndex = 0;
            lbl_concurso_inicial.Text = "Concurso - Início:";
            // 
            // grpCarrinho
            // 
            grpCarrinho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpCarrinho.Controls.Add(dataGridView1);
            grpCarrinho.Controls.Add(textBox1);
            grpCarrinho.Controls.Add(btn_conferir);
            grpCarrinho.Controls.Add(lblNumeros);
            grpCarrinho.Location = new Point(45, 79);
            grpCarrinho.Name = "grpCarrinho";
            grpCarrinho.Size = new Size(944, 298);
            grpCarrinho.TabIndex = 1;
            grpCarrinho.TabStop = false;
            grpCarrinho.Text = "Carrinho";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(923, 188);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(682, 27);
            textBox1.TabIndex = 2;
            // 
            // btn_conferir
            // 
            btn_conferir.Enabled = false;
            btn_conferir.Location = new Point(843, 36);
            btn_conferir.Name = "btn_conferir";
            btn_conferir.Size = new Size(94, 44);
            btn_conferir.TabIndex = 1;
            btn_conferir.Text = "Conferir";
            btn_conferir.UseVisualStyleBackColor = true;
            btn_conferir.Click += btnConferir_Click;
            // 
            // lblNumeros
            // 
            lblNumeros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNumeros.BackColor = Color.FromArgb(192, 0, 192);
            lblNumeros.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeros.ForeColor = Color.White;
            lblNumeros.Location = new Point(14, 35);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(924, 47);
            lblNumeros.TabIndex = 0;
            lblNumeros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_montar_jogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 450);
            Controls.Add(grpCarrinho);
            Controls.Add(grp_filtro);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_montar_jogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Montar Jogo - Avulso";
            WindowState = FormWindowState.Maximized;
            Load += frm_gerar_jogo_Load;
            grp_filtro.ResumeLayout(false);
            grp_filtro.PerformLayout();
            grpCarrinho.ResumeLayout(false);
            grpCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_filtro;
        private Label lbl_concurso_final;
        private Label lbl_concurso_inicial;
        private ComboBox cbo_concurso_fim;
        private ComboBox cbo_concurso_inicio;
        private GroupBox grpCarrinho;
        private Label lblNumeros;
        private Button btn_conferir;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}