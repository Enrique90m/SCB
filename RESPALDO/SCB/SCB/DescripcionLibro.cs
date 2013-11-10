using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class DescripcionLibro : Form
    {
        string id;
        string nombre;
        string autor;
        string estante;
        string charola;

        public DescripcionLibro(DataGridViewRow row)
        {
            InitializeComponent();
            id = row.Cells[0].Value.ToString();
            nombre = row.Cells[1].Value.ToString();
            autor  = row.Cells[3].Value.ToString();
            estante = row.Cells[6].Value.ToString();
            charola = row.Cells[7].Value.ToString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void DescripcionLibro_Load(object sender, EventArgs e)
        {
            txtLibro.Text = nombre;
            textBox1.Text = autor;
            textBox2.Text = estante;
            textBox3.Text = charola;
        }
    }
}
