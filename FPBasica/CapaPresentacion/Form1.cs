using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtEstante.Text = "";
            txtEstanteria.Text = "";
            txtFamilia.Text = "";
            txtMarca.Text = "";
            txtPesoBruto.Text = "";
            txtPesoNeto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtSubfamilia.Text = "";
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto(txtCodigo.Text, txtDescripcion.Text, int.Parse(txtMarca.Text), txtFamilia.Text, txtSubfamilia.Text, float.Parse(txtPrecio.Text), int.Parse(txtStock.Text), txtPesoBruto.Text,txtPesoNeto.Text, txtEstanteria.Text, int.Parse(txtAltura.Text), txtEstante.Text) ;
            MessageBox.Show(Program.gestor.DarAltaProducto(productoNuevo));
        }
    }
}
