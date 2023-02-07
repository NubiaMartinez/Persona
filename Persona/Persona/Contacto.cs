using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Contacto:PersonaPr
    {
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Contacto(string nombre, string apPaterno, string apMaterno, string fechanacimiento, string rfc, string Telefono, string Correo):base(nombre,apPaterno,apMaterno,fechanacimiento,rfc)
        {
            this.Telefono = Telefono;
            this.Correo = Correo;
        }
    }
}
