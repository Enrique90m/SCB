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
        public agregaLibro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Libro Libro = new Libro();
            Libro.Libroo = txtLibro.Text;
            Libro.numLibro = int.Parse(txtNumLibro.Text);
            Libro.materia = txtMateria.Text;
            Libro.fechaEntregar = DateTime.Parse(fechaEntregar.Text);
            Libro.autor = autor.Text;
            Libro.coautor = coautor.Text;
            Libro.charola = int.Parse(textBox1.Text);
            Libro.estante = int.Parse(textBox2.Text);
            Libro.agregaLibro(Libro);

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
            this.lIBROSTableAdapter.Fill(this.bDlibrosDataSet.LIBROS);
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
            this.Validate();
            this.lIBROSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDlibrosDataSet);

        }
    }
}
