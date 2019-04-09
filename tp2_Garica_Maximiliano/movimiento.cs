using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Garica_Maximiliano
{
    class movimiento
    {
        public int numero { get; set; }
        public DateTime fecha { get; set; }
        public cliente cliente { get; set; }
        public List<almacenamiento> productos { get; set; }
    }
}
