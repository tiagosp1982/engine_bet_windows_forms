using motor_aposta.domain.DTO;
using Refit;

namespace motor_aposta.domain.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        [Get("/usuario/logar/{_email}/{_senha}")]
        Task<UsuarioDTO> UsuarioLogon(string _email, string _senha);
    }
}
