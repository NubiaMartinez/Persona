using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            string fecha = fecha_nactxt.Value.ToString("dd/MM/yyyy");
            PersonaPr CalcularR = new PersonaPr(Nombretxt.Text, Apellidop.Text, Apellidom.Text, fecha,RFC_txt.Text);
            string RFC = CalcularR.CalcularR(Nombretxt.Text, Apellidop.Text, Apellidom.Text, fecha);
            Contacto contacto1 = new Contacto(Nombretxt.Text, Apellidop.Text, Apellidom.Text, fecha, RFC, teltxt.Text, Correotxt.Text);

            RFC_txt.Text = RFC.ToString();
        }
    }
}
