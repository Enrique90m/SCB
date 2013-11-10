using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class ConexionBD
    {
        //OBJETO DE CONEXION
        public SqlConnection conexionSQL;
        //RUTA DE LA BASE DE DATOS
        public string path = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\SCB\SCB\BDlibros.mdf;Integrated Security=True;User Instance=True";
        public DataTable dt;
        public SqlDataAdapter da;

        //METODO PARA CONEXTAR CON LA BASE DE DATOS
        public SqlConnection conectaConBD()
        {

            conexionSQL = new SqlConnection(this.path);
            try
            {
                conexionSQL.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar con la base de datos fisica en el sistema, a continuacion se presenta el error\n" + e.ToString());
                return null;
            }
            return conexionSQL;
        }
    }
}
