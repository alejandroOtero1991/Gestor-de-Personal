﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto
{
   public static class conexionDb
    {

        
        public static SqlConnection GetSqlConexion()
        {

            
            string conexion =String.Format( Properties.Settings.Default.connectionString,Environment.CurrentDirectory + "\\Database1.mdf");
            SqlConnection conectar = new SqlConnection(conexion);

            if (conectar.State != ConnectionState.Open) {
                conectar.Open();
            }
            return conectar;
        }
        public static DataTable GetTable(string query) {
            SqlConnection connection = GetSqlConexion();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(query, connection);
            adaptador.Fill(dt);
            return dt;
        }
        public static void ejecutarSql(string sql) {
            SqlConnection connection = GetSqlConexion();
            SqlCommand updateTabla = new SqlCommand(sql, connection);
            updateTabla.ExecuteNonQuery();
            
        }
        public static void CerrarConexionDB() {

            SqlConnection connection = GetSqlConexion();
            
            if (connection.State != ConnectionState.Closed) {
                connection.Close();

            }

        }
    }
}
