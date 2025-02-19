using motor_aposta.domain.DTO;
using Refit;

namespace motor_aposta.domain.Repositories.Interfaces
{
    public interface ITipoJogoRepository
    {
        [Get("/tipo_jogo/listar")]
        Task<List<TipoJogoDTO>> ListaTipoJogo();

        [Get("/tipo_jogo/listar_estrutura/{_id_tipo_jogo}")]
        Task<List<TipoJogoEstruturaDTO>> ListaTipoJogoEstrutura(int _id_tipo_jogo);

        [Get("/tipo_jogo/listar_por_codigo/{_id_tipo_jogo}")]
        Task<TipoJogoDTO> ListaTipoJogoPorId(int _id_tipo_jogo);
    }
}
