using motor_aposta.domain.DTO;
using motor_aposta_win.Control.Configuracao;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace motor_aposta_win.Control
{
    public partial class control_calculo : UserControl
    {
        private readonly string labelAusenciaRecente = "lblQtAusenciaRecente";
        private readonly string labelAusenciaTotal = "lblQtAusenciaTotal";
        private readonly string labelRepeticaoRecente = "lblQtRepeticaoRecente";
        private readonly string labelRepeticaoTotal = "lblQtRepeticaoTotal";
        private readonly string labelProbabilidade = "lblVlProbabilidade";
        private readonly string textoNumeroSelecionado = "Total Selecionado: ";
        private readonly List<CalculoDTO> _calculos;
        private readonly TipoJogoDTO _tipoJogo;
        public event EventHandler<object> btnEvent;
        private List<int> numeros = new List<int>();
        private bool bRepeticaoRecente;
        private bool bRepeticaoTotal;
        private bool bAusenciaRecente;
        private bool bAusenciaTotal;
        private bool bProbabilidade;
        private bool bConfigurado;

        public control_calculo(List<CalculoDTO> calculos, TipoJogoDTO tipoJogo)
        {
            InitializeComponent();
            _calculos = calculos;
            _tipoJogo = tipoJogo;
        }

        private void control_calculo_Load(object sender, EventArgs e)
        {
            foreach (var c in _calculos)
            {
                AtribuiValorLabel(c);
            }
        }

        private void AtribuiValorLabel(CalculoDTO calculo)
        {
            foreach (var group in this.Controls)
            {
                if (group is GroupBox)
                {
                    GroupBox grp = (GroupBox)group;
                    foreach (var control in grp.Controls)
                    {
                        if (control is Label)
                        {
                            var c = control as Label;
                            var propriedade = control.GetType().GetProperty("Text");
                            var textoAtual = propriedade.GetValue(control);

                            if (c.Name == labelAusenciaRecente + calculo.NrDezena.ToString())
                            {
                                propriedade.SetValue(control, textoAtual.ToString() + " " + calculo.QtAusenciaRecente.ToString());
                                if (calculo.QtAusenciaRecente > 0)
                                    c.ForeColor = Color.Orange;
                            }

                            if (c.Name == labelAusenciaTotal + calculo.NrDezena.ToString())
                            {
                                propriedade.SetValue(control, textoAtual.ToString() + " " + calculo.QtAusenciaTotal.ToString());
                                if (calculo.QtAusenciaTotal > 0)
                                    c.ForeColor = Color.IndianRed;
                            }

                            if (c.Name == labelRepeticaoRecente + calculo.NrDezena.ToString())
                            {
                                propriedade.SetValue(control, textoAtual.ToString() + " " + calculo.QtRepeticaoRecente.ToString());
                                if (calculo.QtRepeticaoRecente > 0)
                                    c.ForeColor = Color.DarkRed;
                            }

                            if (c.Name == labelRepeticaoTotal + calculo.NrDezena.ToString())
                            {
                                propriedade.SetValue(control, textoAtual.ToString() + " " + calculo.QtRepeticaoTotal.ToString());
                                if (calculo.QtRepeticaoTotal > 0)
                                    c.ForeColor = Color.MediumPurple;
                            }

                            if (c.Name == labelProbabilidade + calculo.NrDezena.ToString())
                            {
                                propriedade.SetValue(control, textoAtual.ToString() + " " + calculo.VlProbabilidade.ToString());
                                if (calculo.VlProbabilidade > 0)
                                    c.ForeColor = Color.ForestGreen;
                            }
                        }
                    }

                }
            }
        }

        private void AlterarFundoLabelClick(int numero, bool click)
        {
            foreach (var group in this.Controls)
            {
                if (group is GroupBox)
                {
                    GroupBox grp = (GroupBox)group;
                    foreach (var control in grp.Controls)
                    {
                        if (control is Label)
                        {
                            var c = control as Label;
                            if (c.Name == labelAusenciaRecente + numero.ToString() ||
                                c.Name == labelAusenciaTotal + numero.ToString() ||
                                c.Name == labelRepeticaoRecente + numero.ToString() ||
                                c.Name == labelRepeticaoTotal + numero.ToString() ||
                                c.Name == labelProbabilidade + numero.ToString())
                                c.BackColor = (click ? Color.Gray : SystemColors.Control);
                        }
                    }
                }
            }
        }

        private void AlterarVisualizacaoLabel()
        {
            for (int numero = 1; numero <= 25; numero++)
            {
                foreach (var group in this.Controls)
                {
                    if (group is GroupBox)
                    {
                        GroupBox grp = (GroupBox)group;
                        foreach (var control in grp.Controls)
                        {
                            if (control is Label)
                            {
                                var c = control as Label;
                                if (c.Name == labelAusenciaRecente + numero.ToString())
                                {
                                    c.Visible = bAusenciaRecente;
                                }

                                if (c.Name == labelAusenciaTotal + numero.ToString())
                                {
                                    c.Visible = bAusenciaTotal;
                                }

                                if (c.Name == labelRepeticaoRecente + numero.ToString())
                                {
                                    c.Visible = bRepeticaoRecente;
                                }

                                if (c.Name == labelRepeticaoTotal + numero.ToString())
                                {
                                    c.Visible = bRepeticaoTotal;
                                }

                                if (c.Name == labelProbabilidade + numero.ToString())
                                {
                                    c.Visible = bProbabilidade;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ManipulaListaNumeros(int n, bool adiciona)
        {
            bool existe = numeros.Contains(n);
            if (existe && !adiciona)
                numeros.Remove(n);
            if (!existe && adiciona)
                numeros.Add(n);

            MostraNumeroSelecionado();
        }

        private void MostraNumeroSelecionado()
        {
            if (numeros.Count == 0)
            {
                this.lblTotal.BackColor = Color.DarkGray;
                this.lblTotal.ForeColor = Color.White;
            }

            if (numeros.Count > 0 && numeros.Count < _tipoJogo.qt_dezena_minima_aposta)
            {
                this.lblTotal.BackColor = Color.LightYellow;
                this.lblTotal.ForeColor = Color.IndianRed;
            }

            if (numeros.Count >= _tipoJogo.qt_dezena_minima_aposta)
            {
                this.lblTotal.BackColor = Color.LightGreen;
                this.lblTotal.ForeColor = Color.DarkGreen;
            }

            if (numeros.Count == _tipoJogo.qt_dezena_maxima_aposta)
            {
                this.lblTotal.BackColor = Color.DarkBlue;
                this.lblTotal.ForeColor = Color.White;
            }


            this.lblTotal.Text = textoNumeroSelecionado.ToString() + numeros.Count.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn != null)
            {
                bool click = (btn.Tag?.ToString() == "0" ? true : false);
                if ((numeros.Count < _tipoJogo.qt_dezena_maxima_aposta) ||
                        (numeros.Count == _tipoJogo.qt_dezena_maxima_aposta && !click))
                {
                    btn.BackColor = (btn.Tag?.ToString() == "0" ? Color.Gray : SystemColors.Control);

                    btn.Tag = (btn.Tag?.ToString() == "0" ? "1" : "0");
                    AlterarFundoLabelClick(int.Parse(btn.Text), click);
                    ManipulaListaNumeros(int.Parse(btn.Text), click);

                    (int numero, bool evento) valorBotao = (int.Parse(btn.Text), click);
                    btnEvent?.Invoke(this, valorBotao);
                }
            }
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frm_configuracao configuracao = new frm_configuracao();
            configuracao.bRepeticaoRecente = bRepeticaoRecente;
            configuracao.bRepeticaoTotal = bRepeticaoTotal;
            configuracao.bAusenciaRecente = bAusenciaRecente;
            configuracao.bAusenciaTotal = bAusenciaTotal;
            configuracao.bProbabilidade = bProbabilidade;
            configuracao.bConfigurado = bConfigurado;
            configuracao.ShowDialog();

            bRepeticaoRecente = configuracao.bRepeticaoRecente;
            bRepeticaoTotal = configuracao.bRepeticaoTotal;
            bAusenciaRecente = configuracao.bAusenciaRecente;
            bAusenciaTotal = configuracao.bAusenciaTotal;
            bProbabilidade = configuracao.bProbabilidade;
            bConfigurado = configuracao.bConfigurado;
            AlterarVisualizacaoLabel();
        }
    }
}
