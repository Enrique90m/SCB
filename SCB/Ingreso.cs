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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "ADMINISTRADOR" && pass.Text == "480")
            {
                Form1 formu = new Form1(0);
                formu.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formu = new Form1(1);
            formu.Show();
            this.Close();
        }
    }
}
