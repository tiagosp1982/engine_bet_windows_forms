using motor_aposta.domain.DTO;
using motor_aposta.domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motor_aposta_win.Ferramentas
{
    public partial class frm_conferir_resultado : Form
    {
        private readonly IResultadoRepository _resultadoRepository;
        private int _id_tipo_jogo;
        private string _nr_jogo;
        public frm_conferir_resultado(int id_tipo_jogo, string nr_jogo, IResultadoRepository resultadoRepository)
        {
            InitializeComponent();
            _resultadoRepository = resultadoRepository;
            _id_tipo_jogo = id_tipo_jogo;
            _nr_jogo = nr_jogo;
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frm_conferir_resultado_Load(object sender, EventArgs e)
        {
            List<ResultadoDetalhadoDTO> listaDetalhado = await resultadoDetalhado(this.opt_concurso.Checked);
            List<ResultadoConsolidadoDTO> listaConsolidado = await _resultadoRepository.ConfereResultadoConsolidado(this._id_tipo_jogo, this._nr_jogo);

            this.grid_detalhado.DataSource = listaDetalhado;
            this.grid_consolidado.DataSource = listaConsolidado;
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {

        }

        private async void opt_concurso_CheckedChanged(object sender, EventArgs e)
        {
            var lista = await resultadoDetalhado(this.opt_concurso.Checked);
            this.grid_detalhado.DataSource = lista;
        }

        private async Task<List<ResultadoDetalhadoDTO>> resultadoDetalhado(bool por_concurso)
        {
            var listaDetalhado = await _resultadoRepository.ConfereResultadoDetalhado(this._id_tipo_jogo, this._nr_jogo);
            List<ResultadoDetalhadoDTO> lista = (from c in listaDetalhado
                                                 orderby (por_concurso ? c.Concurso : c.Acertos) descending
                                                 select c).ToList();
            return lista;
        }
    }
}
