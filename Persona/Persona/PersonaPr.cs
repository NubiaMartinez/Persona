using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class PersonaPr
    {
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string Fecha_nac { get; set; }
        public string RFC { get; set; }

        public PersonaPr(string Nombre, string Apellidop, string Apellidom, string Fecha_nac,string rfc)
        {
            this.Nombre = Nombre;
            this.Apellidop = Apellidop;
            this.Apellidom = Apellidom;
            this.Fecha_nac = Fecha_nac;
            this.RFC = rfc;
        }
        public String CalcularR(string Nombre, string Apellidop, string Apellidom, string Fecha_nac)
        {
            string conc = ""; 
            this.Apellidop = Apellidop.Substring(0, 2);
            this.Apellidom = Apellidom.Substring(0, 1);
            this.Nombre = Nombre.Substring(0, 1);
            conc += Fecha_nac.Substring(8, 2);
            conc += Fecha_nac.Substring(3, 2);
            conc += Fecha_nac.Substring(0, 2);
            this.Fecha_nac = conc;
            this.RFC = this.Apellidop + this.Apellidom + this.Nombre + this.Fecha_nac;
            return RFC.ToUpper();
        }
    }
}
