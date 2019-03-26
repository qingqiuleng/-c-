using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;



namespace myWarehouse.data
{
    //using System.Runtime.InteropServices;
    //[DllImport("sqlite3.dll")]
    class dataSqlite
    {
        public void createTable()
        {
            try
            {
                string dbPath = System.AppDomain.CurrentDomain.BaseDirectory;
                dbPath = dbPath.Substring(0, dbPath.Length - 10);
                string countdbPath = dbPath + "data\\countTable.db3";
                string warehousedbPath = dbPath + "data\\WarehouseTable.db3";
                //如果不存在改数据库文件，则创建该数据库文件 
                if (!System.IO.File.Exists(countdbPath))
                {
                    System.IO.File.Create(countdbPath);
                }
                if (!System.IO.File.Exists(warehousedbPath))
                {
                    System.IO.File.Create(warehousedbPath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("新建数据库文件失败：" + ex.Message);
            }
        }

        public void initTable()
        {
            string dbPath = System.AppDomain.CurrentDomain.BaseDirectory;
            dbPath = dbPath.Substring(0, dbPath.Length - 10);

            SQLiteConnection con1 = new SQLiteConnection(dbPath + "data\\countTable.db3");
            /*if (con1.State != System.Data.ConnectionState.Open)
            {
                con1.Open();
                SQLiteCommand cmd1 = new SQLiteCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "CREATE TABLE countTable (count varchar,password varchar)";
                cmd1.ExecuteNonQuery();
            }
            con1.Close();*/
         }

     }
}
