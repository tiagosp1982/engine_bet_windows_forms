using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor_aposta.domain.DTO
{
    public class CalculoDTO
    {
        public int NrDezena { get; set; }
        public int QtAusenciaRecente { get; set; }
        public int QtAusenciaTotal { get; set; }
        public int QtRepeticaoRecente { get; set; }
        public int QtRepeticaoTotal { get; set; }
        public double VlProbabilidade { get; set; }
    }
}
