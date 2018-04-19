using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasConArreglos
{
    public partial class Form1 : Form
    {
        Catalogo obj = new Catalogo();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                obj.agregar(txtNombre.Text, txtAño.Text, txtPlaca.Text, txtTelefono.Text);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtResultado.Text = obj.listar();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.eliminar(txtBPlaca.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.insertar(txtNombre.Text, txtAño.Text, txtPlaca.Text, txtTelefono.Text, txtBPlaca.Text);
        }
    }
}
