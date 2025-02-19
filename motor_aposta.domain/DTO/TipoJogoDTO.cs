namespace motor_aposta.domain.DTO
{
    public class TipoJogoDTO
    {
        public int id_tipo_jogo { get; set; }
        public string nm_tipo_jogo { get; set; }
        public int qt_dezena_resultado { get; set; }
        public int qt_dezena_minima_aposta { get; set; }
        public int qt_dezena_maxima_aposta { get; set; }
        public string nm_route { get; set; }
        public int nr_concurso_max { get; set; }
    }
}
