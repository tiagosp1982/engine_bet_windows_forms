using motor_aposta.domain.DTO;
using Refit;

namespace motor_aposta.domain.Repositories.Interfaces
{
    public interface IResultadoRepository
    {
        [Post("/resultado/atualizar/{id_tipo_jogo}")]
        Task AtualizaResultado(int id_tipo_jogo);

        [Get("/resultado/consolidado/{id_tipo_jogo}/{nr_jogo}")]
        Task<List<ResultadoConsolidadoDTO>> ConfereResultadoConsolidado(int id_tipo_jogo, string nr_jogo);

        [Get("/resultado/detalhado/{id_tipo_jogo}/{nr_jogo}")]
        Task<List<ResultadoDetalhadoDTO>> ConfereResultadoDetalhado(int id_tipo_jogo, string nr_jogo);
    }
}
