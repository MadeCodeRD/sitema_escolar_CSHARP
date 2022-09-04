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
    class Cls_Datos:Cls_Connection
    {
        SqlCommand sqlCommand;
        SqlDataAdapter sql_DataAdapter;
        DataSet Datacollection = new DataSet();
        Cls_Connection Clase_Conexion = new Cls_Connection();

        public void InsertarDatos(string Tabla, string Campos, string Valores)
        {
            string query = "INSERT INTO "+ Tabla + "(" + Campos + ") VALUES " + "(" + Valores + ")";

            try
            {
                sqlCommand = new SqlCommand(query, Clase_Conexion.sql_conectar());
                sqlCommand.ExecuteNonQuery();
                Clase_Conexion.sql_Desconectar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


        }


        public DataTable ConsultasDatos(string Campos, string Tabla, string Condicion)
        {
            string query = "SELECT " + Campos + " FROM " + Tabla + " WHERE " + Condicion;

            try
            {
                sql_DataAdapter = new SqlDataAdapter(query, Clase_Conexion.sql_conectar());
                Datacollection.Clear();
                sql_DataAdapter.Fill(Datacollection, "agenda");
                Clase_Conexion.sql_Desconectar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return Datacollection.Tables["agenda"];


        }

        //public void reset_count()
        //{

        //    try
        //    {
        //        string query = "DBCC CHECKIDENT ('[agenda]', RESEED, 0);";

        //        sqlCommand = new SqlCommand(query, Clase_Conexion.sql_conectar());
        //        sqlCommand.ExecuteNonQuery();
        //        Clase_Conexion.sql_Desconectar();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //}


        public void ActualizarDatos(string Tabla, string Campos, string Condicion)
        {
            string query = "UPDATE " + Tabla + " SET " + Campos + " WHERE " + Condicion;

            try
            {
                sqlCommand = new SqlCommand(query, Clase_Conexion.sql_conectar());
                sqlCommand.ExecuteNonQuery();
                Clase_Conexion.sql_Desconectar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public void EliminarDatos(string Tabla, string Condicion)
        {
            string query = "DELETE FROM " + Tabla + " WHERE " + Condicion;
         

            try
            {
                sqlCommand = new SqlCommand(query, Clase_Conexion.sql_conectar());
                sqlCommand.ExecuteNonQuery();
                Clase_Conexion.sql_Desconectar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }




    }
}
