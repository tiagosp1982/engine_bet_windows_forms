namespace motor_aposta_win.Control.Configuracao
{
    public partial class frm_configuracao : Form
    {
        public bool bRepeticaoRecente = true;
        public bool bRepeticaoTotal = true;
        public bool bAusenciaRecente = true;
        public bool bAusenciaTotal = true;
        public bool bProbabilidade = true;
        public bool bConfigurado;
        public frm_configuracao()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            bRepeticaoRecente = (this.chkRepeticaoRecente.Checked ? true : false);
            bRepeticaoTotal = (this.chkRepeticaoTotal.Checked ? true : false);
            bAusenciaRecente = (this.chkAusenciaRecente.Checked ? true : false);
            bAusenciaTotal = (this.chkAusenciaTotal.Checked ? true : false);
            bProbabilidade = (this.chkProbabilidade.Checked ? true : false);
            bConfigurado = true;
            this.Close();
        }

        private void frm_configuracao_Load(object sender, EventArgs e)
        {
            if (bConfigurado)
            {
                this.chkAusenciaRecente.Checked = bAusenciaRecente;
                this.chkAusenciaTotal.Checked = bAusenciaTotal;
                this.chkProbabilidade.Checked = bProbabilidade;
                this.chkRepeticaoRecente.Checked = bRepeticaoRecente;
                this.chkRepeticaoTotal.Checked = bRepeticaoTotal;
            }
        }
    }
}
