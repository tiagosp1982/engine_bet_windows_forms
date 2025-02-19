using motor_aposta.domain.DTO;
using motor_aposta.domain.Helpers;
using motor_aposta.domain.Repositories.Interfaces;
using motor_aposta_win.Control;

namespace motor_aposta_win.Ferramentas
{
    public partial class frm_montar_jogo : Form
    {
        private readonly IConcursoRepository _concursoRepository;
        private readonly ITipoJogoRepository _tipoJogoRepository;
        private readonly ICalculoRepository _calculoRepository;
        public int id_tipo_jogo;
        private control_calculo ucCalculo;
        private bool bCarregado = false;
        private List<int> numeros = new List<int>();
        public frm_montar_jogo(IConcursoRepository concursoRepository, ITipoJogoRepository tipoJogoRepository, ICalculoRepository calculoRepository)
        {
            InitializeComponent();
            _concursoRepository = concursoRepository;
            _tipoJogoRepository = tipoJogoRepository;
            _calculoRepository = calculoRepository;
        }

        private async void frm_gerar_jogo_Load(object sender, EventArgs e)
        {
            await CarregarConcursos();
            var calculos = await CarregaCalculo();
            AdicionarUserControl(calculos.ToList());
            this.bCarregado = true;
        }

        //Incluir na services
        private async Task<TipoJogoDTO> BuscaTipoJogoAsync()
        {
            TipoJogoDTO tipoJogo = await _tipoJogoRepository.ListaTipoJogoPorId(id_tipo_jogo);
            return tipoJogo;
        }

        private async Task<List<ConcursoDTO>> BuscaConcursoAsync()
        {
            List<ConcursoDTO> concursos = await _concursoRepository.ListaConcurso(id_tipo_jogo);
            return concursos;
        }

        //Incluir na services
        private async Task<List<TipoJogoEstruturaDTO>> BuscaTipoJogoEstruturaAsync()
        {
            List<TipoJogoEstruturaDTO> estrutura = await _tipoJogoRepository.ListaTipoJogoEstrutura(id_tipo_jogo);
            return estrutura;
        }

        private async Task<List<CalculoDTO>> BuscaCalculoAsync()
        {
            int nr_concurso_inicio = int.Parse(this.cbo_concurso_inicio.SelectedValue!.ToString()!);
            int nr_concurso_fim = int.Parse(this.cbo_concurso_fim.SelectedValue!.ToString()!);

            List<CalculoDTO> calculos = await _calculoRepository.ListaCalculos(id_tipo_jogo,
                                                                                    nr_concurso_inicio,
                                                                                    nr_concurso_fim);
            return calculos;
        }

        private async void AdicionarUserControl(List<CalculoDTO> calcs)
        {
            //carrega tipo de jogo
            var task_tipo_jogo = BuscaTipoJogoAsync();
            await Task.WhenAll(task_tipo_jogo);
            var tipoJogo = task_tipo_jogo.Result;

            ucCalculo = new control_calculo(calcs, tipoJogo);
            ucCalculo.Location = new Point(-10, 50); // Posição no formulário
            ucCalculo.Size = new Size(this.Size.Width - 50, this.Size.Height - 500); // Tamanho do controle
            ucCalculo.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            ucCalculo.btnEvent += btnEvent_Click;
            this.Controls.Add(ucCalculo); // Adiciona ao Form
        }

        private async Task<bool> CarregarConcursos()
        {
            var task_estrutura = BuscaTipoJogoEstruturaAsync();
            var task_concursos = BuscaConcursoAsync();

            await Task.WhenAll(task_estrutura, task_concursos);

            var estruturas = task_estrutura.Result;
            var concursos = task_concursos.Result;

            var lista = (from c in concursos
                         orderby c.nr_concurso descending
                         select c).ToList();

            this.cbo_concurso_inicio.Items.Clear();
            this.cbo_concurso_inicio.DataSource = concursos;
            this.cbo_concurso_inicio.DisplayMember = "nr_concurso";
            this.cbo_concurso_inicio.ValueMember = "nr_concurso";

            this.cbo_concurso_fim.Items.Clear();
            this.cbo_concurso_fim.DataSource = lista;
            this.cbo_concurso_fim.DisplayMember = "nr_concurso";
            this.cbo_concurso_fim.ValueMember = "nr_concurso";

            if (lista.Count > 0 &&
                lista.Count >= estruturas.Count)
            {
                this.cbo_concurso_inicio.SelectedIndex = lista.Count - estruturas.Count;
                this.cbo_concurso_fim.SelectedIndex = 0;
            }

            return true;
        }

        private async Task<List<CalculoDTO>> CarregaCalculo()
        {
            int nr_concurso_inicio = int.Parse(this.cbo_concurso_inicio.SelectedValue!.ToString()!);
            int nr_concurso_fim = int.Parse(this.cbo_concurso_fim.SelectedValue!.ToString()!);

            if (nr_concurso_inicio > nr_concurso_fim)
            {
                MessageBox.Show(MensagemHelper.msg_concurso_inicio_maior_concurso_fim,
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            var task_calculos = BuscaCalculoAsync();
            await Task.WhenAll(task_calculos);
            var calculos = task_calculos.Result;

            return calculos;
        }

        private void ManipulaListaNumeros(int n, bool adiciona)
        {
            bool existe = numeros.Contains(n);
            if (existe && !adiciona)
                numeros.Remove(n);
            if (!existe && adiciona)
                numeros.Add(n);
            numeros.Sort();
            this.lblNumeros.Text = string.Join("-", numeros);
        }

        private void btnEvent_Click(object sender, object e)
        {
            string[] evento = e.ToString().Replace("(", "")
                                             .Replace(")", "")
                                             .Replace(" ", "")
                                             .Split(",");

            ManipulaListaNumeros(int.Parse(evento[0]), bool.Parse(evento[1]));
        }

        private async void cbo_concurso_inicio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bCarregado)
            {
                this.Controls.Remove(ucCalculo);
                var calculos = await CarregaCalculo();
                AdicionarUserControl(calculos.ToList());
            }
        }
    }
}
