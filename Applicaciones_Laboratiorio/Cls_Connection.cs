using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Applicaciones_Laboratiorio
{
    class Cls_Connection
    {
        SqlConnection conexion_sql;
        SqlCommand command_sql;
        SqlDataReader dataReader_sql;

        public Cls_Connection()
        {
            conexion_sql = new SqlConnection("Data Source=DESKTOP-JQ0M8PH;Initial Catalog=Programa;Integrated Security=True");
        }

        public SqlConnection sql_conectar()
        {

            try
            {
                conexion_sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return conexion_sql;

        }

        public void sql_Desconectar()
        {

            try
            {
                conexion_sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Validar_Usuario(string user, string password)
        {
            bool validar = false;

            string query= "SELECT Id_Usuario,Pass FROM dbo.usuario WHERE Id_Usuario= '" + user + "' AND Pass= '" + password +"'";

            command_sql = new SqlCommand(query, sql_conectar());

            dataReader_sql = command_sql.ExecuteReader();
            
            if(dataReader_sql.HasRows)
            {
                validar = true;
            }


            return validar;
        }



    }
}
