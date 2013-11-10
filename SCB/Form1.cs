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
    public partial class Form1 : Form
    {
        public int activado1;

        public Form1(int activado)
        {
            activado1 = activado;
            InitializeComponent();
            if (activado1 == 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                return;
            }

            //button2.Enabled = false;
            //button3.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e,int r)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodosLosLibros agrega = new TodosLosLibros();
            agrega.Show();
       //     this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregaLibro agrega = new agregaLibro();
            agrega.Show();
           // this.Hide();
        }

        private void usarElSistemaComoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enviarUnCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enviarCorreo enviar = new enviarCorreo();
            enviar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
