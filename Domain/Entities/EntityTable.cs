using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RodmotDTO
    {
        public string NOMMOT { get; set; }
        public int CODMOT { get; set; }
        public int CODPAD { get; set; }
        public int CODFIL { get; set; }
        public int CODMUN { get; set; }
        public string VEICFIX { get; set; }
        public DateTime DATATU { get; set; }
        public string USUATU { get; set; }
    }
}
