using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor_aposta.domain.Helpers
{
    public static class MensagemHelper
    {
        public static string msg_email_vazio = "Preencha o e-mail";
        public static string msg_senha_vazio = "Preencha a senha";
        public static string msg_credencial_invalida = "E-mail e/ou senha inválida";
        public static string msg_concurso_inicio_maior_concurso_fim = "O concurso início deve ser menor do que o concurso fim";
    }
}
