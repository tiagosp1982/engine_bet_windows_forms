namespace motor_aposta.domain.DTO
{
    public class UsuarioDTO
    {
        public int id_usuario { get; set; }
        public string nm_usuario { get; set; }
        public string ds_email { get; set; }
        public string ds_hashsenha { get; set; }
        public string dt_nascimento { get; set; }
        public string dt_cadastro { get; set; }
        public string ds_numero_celular { get; set; }
    }
}
