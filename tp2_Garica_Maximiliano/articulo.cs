using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Garica_Maximiliano
{
    class articulo
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public undMedida undMedida { get; set; }
        public cliente cliente { get; set; }
        public tipoArticulo tipo { get; set; }
    }
}
