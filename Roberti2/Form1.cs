using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roberti2
{
    public partial class Form1 : Form
    {
        int _anguloActual { get; set; }
        int _distanciaActual { get; set; }

        bool _visible = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_visible)
            {
                panel1.Visible = true;
                Services.Controller.SetRequest(0, 0);
                _anguloActual = 0;
            }
            else
                panel1.Visible = true;
            label1.Text = _anguloActual.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Arriba
            _anguloActual = Convert.ToInt32(nudGiro.Value);
            Services.Controller.SetRequest(_anguloActual, Convert.ToInt32(nudArriba.Value));
            label1.Text = _anguloActual.ToString();
        }
    }
}
