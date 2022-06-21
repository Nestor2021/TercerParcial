using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAeropuerto.Models;

namespace WindowsFormsAeropuerto.Presentacion
{
    public partial class frmNuevo : Form
    {
        public frmNuevo()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (AeropuertoEntities db = new AeropuertoEntities())
            {
                avion oavion = new avion();
                oavion.NombreAvion = txtnombre.Text;
                oavion.marca = txtmarca.Text;
                oavion.capacidad =int.Parse(txtcapacidad.Text);
                oavion.descripcion = txtdescripcion.Text;
                db.avion.Add(oavion);
                db.SaveChanges();
                MessageBox.Show("Se ha registrado correctamento");
                this.Close();
            }
        }
    }
}
