using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor_aposta.domain.DTO
{
    public class ConcursoDTO
    {
        public int id_tipo_jogo { get; set; }
        public int nr_concurso { get; set; }
        public DateTime dt_concurso { get; set; }
        public string vl_acumulado { get; set; }
        public int nr_proximo_concurso { get; set; }
        public DateTime dt_proximo_concurso { get; set; }
        public int nr_ganhador { get; set; }
    }
}
