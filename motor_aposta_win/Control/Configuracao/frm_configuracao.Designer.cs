namespace motor_aposta_win.Control.Configuracao
{
    partial class frm_configuracao
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
            chkAusenciaRecente = new CheckBox();
            chkAusenciaTotal = new CheckBox();
            chkRepeticaoRecente = new CheckBox();
            chkRepeticaoTotal = new CheckBox();
            chkProbabilidade = new CheckBox();
            btnAplicar = new Button();
            SuspendLayout();
            // 
            // chkAusenciaRecente
            // 
            chkAusenciaRecente.AutoSize = true;
            chkAusenciaRecente.Checked = true;
            chkAusenciaRecente.CheckState = CheckState.Checked;
            chkAusenciaRecente.Location = new Point(45, 23);
            chkAusenciaRecente.Name = "chkAusenciaRecente";
            chkAusenciaRecente.Size = new Size(147, 24);
            chkAusenciaRecente.TabIndex = 0;
            chkAusenciaRecente.Text = "Ausência Recente";
            chkAusenciaRecente.UseVisualStyleBackColor = true;
            // 
            // chkAusenciaTotal
            // 
            chkAusenciaTotal.AutoSize = true;
            chkAusenciaTotal.Checked = true;
            chkAusenciaTotal.CheckState = CheckState.Checked;
            chkAusenciaTotal.Location = new Point(45, 53);
            chkAusenciaTotal.Name = "chkAusenciaTotal";
            chkAusenciaTotal.Size = new Size(127, 24);
            chkAusenciaTotal.TabIndex = 1;
            chkAusenciaTotal.Text = "Ausência Total";
            chkAusenciaTotal.UseVisualStyleBackColor = true;
            // 
            // chkRepeticaoRecente
            // 
            chkRepeticaoRecente.AutoSize = true;
            chkRepeticaoRecente.Checked = true;
            chkRepeticaoRecente.CheckState = CheckState.Checked;
            chkRepeticaoRecente.Location = new Point(45, 83);
            chkRepeticaoRecente.Name = "chkRepeticaoRecente";
            chkRepeticaoRecente.Size = new Size(155, 24);
            chkRepeticaoRecente.TabIndex = 2;
            chkRepeticaoRecente.Text = "Repetição Recente";
            chkRepeticaoRecente.UseVisualStyleBackColor = true;
            // 
            // chkRepeticaoTotal
            // 
            chkRepeticaoTotal.AutoSize = true;
            chkRepeticaoTotal.Checked = true;
            chkRepeticaoTotal.CheckState = CheckState.Checked;
            chkRepeticaoTotal.Location = new Point(45, 113);
            chkRepeticaoTotal.Name = "chkRepeticaoTotal";
            chkRepeticaoTotal.Size = new Size(135, 24);
            chkRepeticaoTotal.TabIndex = 3;
            chkRepeticaoTotal.Text = "Repetição Total";
            chkRepeticaoTotal.UseVisualStyleBackColor = true;
            // 
            // chkProbabilidade
            // 
            chkProbabilidade.AutoSize = true;
            chkProbabilidade.Checked = true;
            chkProbabilidade.CheckState = CheckState.Checked;
            chkProbabilidade.Location = new Point(45, 143);
            chkProbabilidade.Name = "chkProbabilidade";
            chkProbabilidade.Size = new Size(125, 24);
            chkProbabilidade.TabIndex = 4;
            chkProbabilidade.Text = "Probabilidade";
            chkProbabilidade.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.Lime;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Location = new Point(76, 187);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(94, 31);
            btnAplicar.TabIndex = 5;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // frm_configuracao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 230);
            Controls.Add(btnAplicar);
            Controls.Add(chkProbabilidade);
            Controls.Add(chkRepeticaoTotal);
            Controls.Add(chkRepeticaoRecente);
            Controls.Add(chkAusenciaTotal);
            Controls.Add(chkAusenciaRecente);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_configuracao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração";
            Load += frm_configuracao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAusenciaRecente;
        private CheckBox chkAusenciaTotal;
        private CheckBox chkRepeticaoRecente;
        private CheckBox chkRepeticaoTotal;
        private CheckBox chkProbabilidade;
        private Button btnAplicar;
    }
}