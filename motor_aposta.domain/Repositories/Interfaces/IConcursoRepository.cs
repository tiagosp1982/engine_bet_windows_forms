using motor_aposta.domain.DTO;
using Refit;

namespace motor_aposta.domain.Repositories.Interfaces
{
    public interface IConcursoRepository
    {
        [Get("/concurso/listar/{_id_tipo_jogo}")]
        Task<List<ConcursoDTO>> ListaConcurso(int _id_tipo_jogo);
    }
}
