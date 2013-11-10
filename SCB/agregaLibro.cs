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
    public partial class agregaLibro : Form
    {
        string path = "";
        string nombre;

        public agregaLibro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            Libro Libro = new Libro();
            Libro.Libroo = txtLibro.Text;
            Libro.numLibro = int.Parse(txtNumLibro.Text);
            Libro.materia = txtMateria.Text;
            Libro.fechaEntregar = DateTime.Parse(fechaEntregar.Text);
            Libro.autor = autor.Text;
            Libro.coautor = coautor.Text;
            Libro.charola = int.Parse(textBox1.Text);
            Libro.estante = int.Parse(textBox2.Text);
            Libro.descripcion = textBox3.Text;
            if (path != "")
            {
                Libro.path = path;
                try
                {
                    System.IO.File.Copy(path, @"C:\SCB\SCB\Resources\" + nombre, true);
                }
                catch (Exception w)
                {
                    MessageBox.Show("Error al copiar el archivo! \n\n\n\n" + w.ToString());
                    return;
                }
            }

            Libro.agregaLibro(Libro);
            toolStripStatusLabel1.Text = "Usuario agregado correctamente!";
            toolStripProgressBar1.Value = 100;


            txtLibro.Text = "";
            txtNumLibro.Text = "";
            txtMateria.Text = "";
            fechaEntregar.Text = "";
            autor.Text = "";
            coautor.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            txtNumLibro.Focus();
        }

        private void agregaLibro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDlibrosDataSet.LIBROS' table. You can move, or remove it, as needed.
           
            txtNumLibro.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void coautor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void lIBROSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            if (path.EndsWith(".jpg") || path.EndsWith(".JGP") ||
              path.EndsWith(".jpeg") || path.EndsWith(".JPEG"))
            {            
                nombre = openFileDialog1.SafeFileName;
            }
            else
               MessageBox.Show("El archivo selecionado no es una imagen!");



        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void txtLibro_TextChanged(object sender, EventArgs e)
        {
            this.txtLibro.Text.ToUpper();
        }

        private void txtMateria_Leave(object sender, EventArgs e)
        {
            txtMateria.Text = txtMateria.Text.ToUpper();
        }

        private void autor_Leave(object sender, EventArgs e)
        {
            autor.Text = autor.Text.ToUpper();
        }

        private void coautor_Leave(object sender, EventArgs e)
        {
          coautor.Text =  coautor.Text.ToUpper();

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           textBox3.Text =  textBox3.Text.ToUpper();
        }

        private void txtLibro_Leave(object sender, EventArgs e)
        {
            txtLibro.Text = txtLibro.Text.ToUpper();
        }

        
    }
}
