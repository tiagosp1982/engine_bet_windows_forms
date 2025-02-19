using motor_aposta.domain.Helpers;
using motor_aposta.domain.Repositories.Interfaces;

namespace motor_aposta_win.Login
{
    public partial class frm_login : Form
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ITipoJogoRepository _tipoJogoRepository;
        private bool _isLogin = false;
        public int id_tipo_jogo;

        public frm_login(IUsuarioRepository usuarioRepository, ITipoJogoRepository tipoJogoRepository)
        {
            InitializeComponent();
            _usuarioRepository = usuarioRepository;
            _tipoJogoRepository = tipoJogoRepository;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_logar_Click(object sender, EventArgs e)
        {
            var email = this.txt_email.Text;
            var senha = this.txt_senha.Text;

            var usuario = await _usuarioRepository.UsuarioLogon(email, senha);

            if (usuario != null)
            {
                id_tipo_jogo = Convert.ToInt32(cbo_tipo_jogo.SelectedValue);
                _isLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(MensagemHelper.msg_credencial_invalida, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txt_email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validaEmail();
        }

        private bool validaEmail()
        {
            bool bValido = true;
            if (txt_email.Text == "")
            {
                errorProvider1.SetError(txt_email, MensagemHelper.msg_email_vazio);
                bValido = false;
            }
            else
            {
                errorProvider1.SetError(txt_email, "");
            }
            return bValido;
        }

        private void txt_senha_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validaSenha();
        }

        private bool validaSenha()
        {
            bool bValido = true;
            if (txt_senha.Text == "")
            {
                errorProvider1.SetError(txt_senha, MensagemHelper.msg_senha_vazio);
                bValido = false;
            }
            else
            {
                errorProvider1.SetError(txt_senha, "");
            }
            return bValido;
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLogin)
                Application.Exit();
        }

        private async void frm_login_Load(object sender, EventArgs e)
        {
            var lista_tipo_jogo = await _tipoJogoRepository.ListaTipoJogo();
            this.cbo_tipo_jogo.Items.Clear();
            this.cbo_tipo_jogo.DataSource = lista_tipo_jogo;
            this.cbo_tipo_jogo.DisplayMember = "nm_tipo_jogo";
            this.cbo_tipo_jogo.ValueMember = "id_tipo_jogo";


        }
    }
}
