using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Energywateraccoubting
{
    class dbdatahandler
    {
        private static MySqlConnection mcon1;
        public static int[] retdb(string tablename, string fieldname, string term)
        {
            
            if (mcon1 == null) 
            {
               mcon1 = InitConnection();
            }
            MySqlCommand str = new MySqlCommand();
            str.Connection = mcon1;
            //creating query
            str.CommandType = CommandType.Text;
            if (term == null)
            {
                str.CommandText = "Select " + fieldname +" from " + tablename + ";";
            }
            else
            {
                str.CommandText = "Select " + fieldname + " from " + tablename + " where "+ term + ";";
            }
            //realise query
            DataSet res = new DataSet("res");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = str;
            da.Fill(res);
            int z = res.Tables[0].Rows.Count;
            int[] columns = new int[z];
            for (int i = 0; i < z; i++)
            {
                columns[i] = Convert.ToInt32(res.Tables[0].Rows[i].ItemArray[0]);
            }
            return columns;
        }

        private static MySqlConnection InitConnection()
        {
            //creating connection
            MySqlConnection mcon1;
            mcon1 = new MySqlConnection();
            mcon1.ConnectionString = "server=10.0.2.2;User Id=root;password=po12jein45bf;Persist Security Info=True;database=ewaccounting";

            return mcon1;
        }
    }
}
