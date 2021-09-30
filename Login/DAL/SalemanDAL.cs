using System;
using MySql.Data.MySqlClient;
using Persistence;

namespace DAL
{
    public class SalemanDAL
    {
        MySqlConnection connection = DbHelper.GetConnection();
        public int Login(Saleman saleman)
        {
            int login = 0;
            //Console.WriteLine(cashier.UserName + " - " + cashier.Password);
            try
            {
                
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                    // command.CommandText = "select * from Cashier where user_name='" + 
                    // cashier.UserName + "' and user_pass='" + 
                    // MD5Algorithsm.CreateMD5(cashier.Password)+"';";
                    command.CommandText = "select * from Saleman where user_name=@userName and user_pass=@userPass";
                    command.Parameters.AddWithValue("@userName", saleman.UserName);
                    command.Parameters.AddWithValue("@userPass", MD5Algorithsm.CreateMD5(saleman.Password));
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    login = reader.GetInt32("role");
                }else{
                    login = 0;
                }
            }catch{
                login = -1;
            }
            //Console.WriteLine(login);
            return login;
        }
    }
}