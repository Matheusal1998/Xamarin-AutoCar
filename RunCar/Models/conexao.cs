using Android.Widget;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunCar.Models
{
     class conexao
    {

        public string conec = "SERVER=mysql669.umbler.com;DATABASE=escolaingleshapp; UID=malspfc;PWD=161116Mj;port=41890";
        public MySqlConnection con = null;

        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception)
            {
              
                throw;
            }
        }
        public void fechae()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    
}
