using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class TodosLosLibros : Form
    {
        public TodosLosLibros()
        {
            InitializeComponent();
        }

        private void agregarLibro_Load(object sender, EventArgs e)
        {
            Libro lb = new Libro();
            DataTable dt = new DataTable();
            lb.buscalibro(dt,"SELECT * FROM LIBROS");
            dataGridView1.DataSource = dt;
            textBox1.Focus();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libro lb = new Libro();
            DataTable dt = new DataTable();
           string texto = textBox1.Text;
           if (id_RADIOBUTTON.Checked)
           {
               try
               {
                   Int32.Parse(textBox1.Text);
               }
               catch
               {
                   MessageBox.Show("Ingreso algun dato que no es un numero, porfavor verifique!");
                   return;
               }
               lb.buscalibro(dt, "SELECT * FROM LIBROS WHERE ID_LIBRO = " + textBox1.Text);
           }
           else
               if (libro_RADIOBUTTON.Checked)
                   lb.buscalibro(dt, "SELECT * FROM LIBROS WHERE NOMBRE = '" + textBox1.Text+"'");
               else              
                   lb.buscalibro(dt, "SELECT * FROM LIBROS WHERE AUTOR = '" + textBox1.Text+"'");
               
           

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Libro lb = new Libro();
            DataTable dt = new DataTable();
            lb.buscalibro(dt,"SELECT * FROM LIBROS");
            dataGridView1.DataSource = dt;
        }

        private void gggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>1)
                return;
          
           // DataRow row = new DataRow();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            DescripcionLibro form = new DescripcionLibro(row);
            form.Show();
        }
    }
}
