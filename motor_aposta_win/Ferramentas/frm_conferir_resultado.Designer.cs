namespace motor_aposta_win.Ferramentas
{
    partial class frm_conferir_resultado
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
            grp_consolidado = new GroupBox();
            grid_consolidado = new DataGridView();
            grp_detalhado = new GroupBox();
            opt_acerto = new RadioButton();
            opt_concurso = new RadioButton();
            grid_detalhado = new DataGridView();
            lbl_aviso = new Label();
            btn_nao = new Button();
            btn_sim = new Button();
            grp_consolidado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_consolidado).BeginInit();
            grp_detalhado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_detalhado).BeginInit();
            SuspendLayout();
            // 
            // grp_consolidado
            // 
            grp_consolidado.Controls.Add(grid_consolidado);
            grp_consolidado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_consolidado.ForeColor = Color.Blue;
            grp_consolidado.Location = new Point(24, 21);
            grp_consolidado.Name = "grp_consolidado";
            grp_consolidado.Size = new Size(416, 326);
            grp_consolidado.TabIndex = 0;
            grp_consolidado.TabStop = false;
            grp_consolidado.Text = "Consolidado";
            // 
            // grid_consolidado
            // 
            grid_consolidado.AllowUserToAddRows = false;
            grid_consolidado.AllowUserToDeleteRows = false;
            grid_consolidado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_consolidado.Location = new Point(22, 43);
            grid_consolidado.Name = "grid_consolidado";
            grid_consolidado.ReadOnly = true;
            grid_consolidado.RowHeadersWidth = 51;
            grid_consolidado.Size = new Size(371, 234);
            grid_consolidado.TabIndex = 0;
            // 
            // grp_detalhado
            // 
            grp_detalhado.Controls.Add(opt_acerto);
            grp_detalhado.Controls.Add(opt_concurso);
            grp_detalhado.Controls.Add(grid_detalhado);
            grp_detalhado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_detalhado.ForeColor = Color.Fuchsia;
            grp_detalhado.Location = new Point(446, 21);
            grp_detalhado.Name = "grp_detalhado";
            grp_detalhado.Size = new Size(416, 326);
            grp_detalhado.TabIndex = 1;
            grp_detalhado.TabStop = false;
            grp_detalhado.Text = "Detalhado";
            // 
            // opt_acerto
            // 
            opt_acerto.AutoSize = true;
            opt_acerto.Location = new Point(185, 293);
            opt_acerto.Name = "opt_acerto";
            opt_acerto.Size = new Size(105, 24);
            opt_acerto.TabIndex = 2;
            opt_acerto.Text = "Por Acerto";
            opt_acerto.UseVisualStyleBackColor = true;
            // 
            // opt_concurso
            // 
            opt_concurso.AutoSize = true;
            opt_concurso.Checked = true;
            opt_concurso.Location = new Point(27, 291);
            opt_concurso.Name = "opt_concurso";
            opt_concurso.Size = new Size(123, 24);
            opt_concurso.TabIndex = 1;
            opt_concurso.TabStop = true;
            opt_concurso.Text = "Por Concurso";
            opt_concurso.UseVisualStyleBackColor = true;
            opt_concurso.CheckedChanged += opt_concurso_CheckedChanged;
            // 
            // grid_detalhado
            // 
            grid_detalhado.AllowUserToAddRows = false;
            grid_detalhado.AllowUserToDeleteRows = false;
            grid_detalhado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_detalhado.Location = new Point(21, 43);
            grid_detalhado.Name = "grid_detalhado";
            grid_detalhado.ReadOnly = true;
            grid_detalhado.RowHeadersWidth = 51;
            grid_detalhado.Size = new Size(371, 234);
            grid_detalhado.TabIndex = 0;
            // 
            // lbl_aviso
            // 
            lbl_aviso.AutoSize = true;
            lbl_aviso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_aviso.ForeColor = SystemColors.HotTrack;
            lbl_aviso.Location = new Point(359, 364);
            lbl_aviso.Name = "lbl_aviso";
            lbl_aviso.Size = new Size(192, 20);
            lbl_aviso.TabIndex = 2;
            lbl_aviso.Text = "Deseja salvar essa aposta?";
            // 
            // btn_nao
            // 
            btn_nao.BackColor = Color.FromArgb(255, 128, 128);
            btn_nao.FlatStyle = FlatStyle.Flat;
            btn_nao.ForeColor = Color.Black;
            btn_nao.Location = new Point(467, 388);
            btn_nao.Name = "btn_nao";
            btn_nao.Size = new Size(94, 43);
            btn_nao.TabIndex = 7;
            btn_nao.Text = "Não";
            btn_nao.UseVisualStyleBackColor = false;
            btn_nao.Click += btn_nao_Click;
            // 
            // btn_sim
            // 
            btn_sim.BackColor = Color.Lime;
            btn_sim.FlatStyle = FlatStyle.Flat;
            btn_sim.Location = new Point(352, 388);
            btn_sim.Name = "btn_sim";
            btn_sim.Size = new Size(94, 43);
            btn_sim.TabIndex = 6;
            btn_sim.Text = "Sim";
            btn_sim.UseVisualStyleBackColor = false;
            btn_sim.Click += btn_sim_Click;
            // 
            // frm_conferir_resultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(871, 446);
            Controls.Add(btn_nao);
            Controls.Add(btn_sim);
            Controls.Add(lbl_aviso);
            Controls.Add(grp_detalhado);
            Controls.Add(grp_consolidado);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_conferir_resultado";
            Text = "Conferência de Resultado";
            Load += frm_conferir_resultado_Load;
            grp_consolidado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_consolidado).EndInit();
            grp_detalhado.ResumeLayout(false);
            grp_detalhado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_detalhado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grp_consolidado;
        private DataGridView grid_consolidado;
        private GroupBox grp_detalhado;
        private DataGridView grid_detalhado;
        private Label lbl_aviso;
        private Button btn_nao;
        private Button btn_sim;
        private RadioButton opt_concurso;
        private RadioButton opt_acerto;
    }
}