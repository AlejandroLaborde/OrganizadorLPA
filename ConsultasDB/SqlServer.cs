using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsultasDB
{
    public static class SqlServer
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        public static List<Moneda> obtieneMonedas()
        {

            List<Moneda> monedas = new List<Moneda>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT * FROM[OrganizadorLabordeParodi].[dbo].[Monedas]");
                comando.CommandText = sb.ToString();
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Moneda aux = new Moneda((int)oDr["monedaID"], oDr["moneda"].ToString());
                    monedas.Add(aux);
                }
            
            }
            finally
            {
                conexion.Close();
            }

            return monedas;
        }



        static SqlServer()
        {
            string connectionStr = "Data Source=ALEJANDRO-PC\\SQLEXPRESS;Initial Catalog =OrganizadorLabordeParodi; Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

    }
}
