using motor_aposta.domain.DTO;
using Refit;

namespace motor_aposta.domain.Repositories.Interfaces
{
    public interface ICalculoRepository
    {
        [Get("/calculo/dezenas/{_id_tipo_jogo}/{_nr_concurso_inicial}/{_nr_concurso_final}")]
        public Task<List<CalculoDTO>> ListaCalculos(int _id_tipo_jogo, int _nr_concurso_inicial, int _nr_concurso_final);
    }
}
