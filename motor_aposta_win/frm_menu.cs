using motor_aposta.domain.DTO;
using motor_aposta.domain.Repositories.Interfaces;
using motor_aposta_win.Ferramentas;
using motor_aposta_win.Login;
namespace motor_aposta_win
{
    public partial class frm_menu : Form
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ITipoJogoRepository _tipoJogoRepository;
        private readonly IConcursoRepository _concursoRepository;
        private readonly ICalculoRepository _calculoRepository;
        private readonly IResultadoRepository _resultadoRepository;
        private int _id_tipo_jogo;

        public frm_menu(IUsuarioRepository usuarioRepository, ITipoJogoRepository tipoJogoRepository,
            IConcursoRepository concursoRepository, ICalculoRepository calculoRepository, IResultadoRepository resultadoRepository)
        {
            InitializeComponent();
            _usuarioRepository = usuarioRepository;
            _tipoJogoRepository = tipoJogoRepository;
            _concursoRepository = concursoRepository;
            _calculoRepository = calculoRepository;
            _resultadoRepository = resultadoRepository;

            this.lbl_dt_proximo_concurso_var.Text = string.Empty;
            this.lbl_ganhadores_var.Text = string.Empty;
            this.lbl_proximo_concurso_var.Text = string.Empty;
            this.lbl_ultimo_concurso_var.Text = string.Empty;
            this.lbl_valor_acumulado_var.Text = string.Empty;
        }

        private async Task carrega_form()
        {
            List<ConcursoDTO> concursos = await _concursoRepository.ListaConcurso(_id_tipo_jogo);
            var ultimo_concurso = (from c in concursos
                                   orderby c.nr_concurso descending
                                   select c).FirstOrDefault();

            this.grp_concurso.Visible = true;
            this.lbl_dt_proximo_concurso_var.Text = ultimo_concurso.dt_proximo_concurso.ToString("dd/MM/yyyy");
            this.lbl_ganhadores_var.Text = ultimo_concurso.nr_ganhador.ToString();
            this.lbl_proximo_concurso_var.Text = ultimo_concurso.nr_proximo_concurso.ToString();
            this.lbl_ultimo_concurso_var.Text = ultimo_concurso.nr_concurso.ToString();
            this.lbl_valor_acumulado_var.Text = string.Format("{0:C}", decimal.Parse(ultimo_concurso.vl_acumulado.Replace(".", ",")));

            if (ultimo_concurso.dt_proximo_concurso < DateTime.Today.Date)
                this.grp_atualizacao.Visible = true;
        }

        private async void frm_menu_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login(_usuarioRepository, _tipoJogoRepository);
            login.ShowDialog();
            _id_tipo_jogo = login.id_tipo_jogo;

            await this.carrega_form();
        }

        private void btn_atualizar_nao_Click(object sender, EventArgs e)
        {
            this.grp_atualizacao.Visible = false;
        }

        private void montarJogoAvulsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_montar_jogo frm = new frm_montar_jogo(_id_tipo_jogo, _concursoRepository, _tipoJogoRepository, _calculoRepository, _resultadoRepository);
            frm.ShowDialog();
        }

        private async void btn_atualizar_sim_Click(object sender, EventArgs e)
        {
            await _resultadoRepository.AtualizaResultado(_id_tipo_jogo);
            await this.carrega_form();
            this.grp_atualizacao.Visible = false;
        }
    }
}
