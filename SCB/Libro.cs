using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;
namespace Biblioteca
{
    class Libro
    {
        public int numLibro;
        public string Libroo;
        public string materia;
        public DateTime fechaEntregar;
        public DateTime fechaCreacion;
        public string autor;
        public string coautor;
        public int estante;
        public int charola;
        public string path;
        public string descripcion;

        public void agregaLibro(Libro objetoLibro)
        {
            ConexionBD bd = new ConexionBD();
            SqlCeConnection conexion = bd.conectaConBD();
            try
            {
                SqlCeCommand comando = new SqlCeCommand("INSERT INTO LIBROS VALUES('" + objetoLibro.numLibro + "','" + objetoLibro.Libroo + "','" + objetoLibro.materia + "','" +objetoLibro.autor+"','"+objetoLibro.coautor+"','"+ objetoLibro.fechaEntregar +"','"+objetoLibro.charola+"','"+objetoLibro.estante+ "')", conexion);
                comando.ExecuteNonQuery();
                comando = new SqlCeCommand("INSERT INTO DESCRIPCION VALUES('" + objetoLibro.numLibro + "','" + objetoLibro.descripcion + "','" + objetoLibro.path + "')", conexion);
                comando.ExecuteNonQuery();
               // MessageBox.Show("Libro agregada correctamente!");
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error durante el proceso de agregar la Libro, no se agrego ningun dato! \n \n " + e.ToString());
                return;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable obtieneCuantasLibros(DataTable dt)
        {
            ConexionBD bd = new ConexionBD();
            SqlCeConnection conexion = bd.conectaConBD();
            try
            {
                SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM LibroS", conexion);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("", "Error - No se pudo contar el total de Libros \n \n" + e.ToString());
            }
            return dt;
        }
        public DataTable buscalibro(DataTable dt, string comando)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCeConnection cn = conexion.conectaConBD();
            try
            {
                SqlCeDataAdapter da = new SqlCeDataAdapter(comando, cn);
                da.Fill(dt);
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocurrio un error en el sistema: \n\n + "+ e.ToString());
                return dt;
            }
            return dt;
        }
        public DataRow buscaDescripcion(string id)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCeConnection cn = conexion.conectaConBD();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM DESCRIPCION WHERE ID = " + id, cn);
            da.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
    }
}
