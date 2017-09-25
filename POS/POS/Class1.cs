using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;





namespace POS
{
    class Class1
    {
      public  MySqlConnection g = new MySqlConnection("server=localhost;database=pos;uid=carl;");
        public void gege()
        {
            if (g.State == System.Data.ConnectionState.Open)
            {
                g.Close();
            }
            g.Open();
        }
        public void cmd(string a)  
        {
            gege();
            MySqlCommand haha = new MySqlCommand(a, g);
            haha.ExecuteNonQuery();
        }
       

    }
}
