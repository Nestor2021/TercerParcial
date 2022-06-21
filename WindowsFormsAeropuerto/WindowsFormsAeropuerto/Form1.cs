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

namespace WindowsFormsAeropuerto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER

        private void Refrescar()
        {
            using (AeropuertoEntities db = new AeropuertoEntities())
            {
                var lst = from d in db.avion select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion

        private void btn_Click(object sender, EventArgs e)
        {
            Presentacion.frmNuevo oAgregar = new Presentacion.frmNuevo();
            oAgregar.ShowDialog();
            Refrescar();
        }
    }
}
