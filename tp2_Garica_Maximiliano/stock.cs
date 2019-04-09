using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Garica_Maximiliano
{
    class stock
    {
        public ingreso datosIngreso { get; set; }
        public deposito deposito { get; set; }
        public cliente cliente { get; set; }
        public proveedor proveedor { get; set; }
        public almacenamiento almacenamiento { get; set; }
        public ubicacion posicion { get; set; }
        public egreso DatosEgreso { get; set; }

    }
}
