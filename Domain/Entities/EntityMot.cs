using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MotoristaDTO
    {
        public string NOMEMOTORISTA { get; set; }
        public int CODIGOMOTORISTA { get; set; }
        public int CODPAD { get; set; }
        public int CODIGOFILIAL { get; set; }
        public int CODIGOMUNICIPIO { get; set; }
        public string VEICULOFIXO { get; set; }
        public DateTime DATADEATUALIZACAO { get; set; }
        public string USUARIODEATUALIZACAO { get; set; }
    }

}
