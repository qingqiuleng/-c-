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
        private SQLiteConnection m_dbCountConnection;
        private SQLiteConnection m_dbMessageConnection;
        public void createTable()
        {
            try
            {
                string dbPath = System.AppDomain.CurrentDomain.BaseDirectory;
                dbPath = dbPath.Substring(0, dbPath.Length - 10);
                string countdbPath = dbPath + "data\\countData.sqlite";
                string warehousedbPath = dbPath + "data\\WarehouseData.sqlite";
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
            try
            {
                string dbPath = System.AppDomain.CurrentDomain.BaseDirectory;
                dbPath = dbPath.Substring(0, dbPath.Length - 10);
                string countdbPath = dbPath + "data\\countData.sqlite";
                string warehousedbPath = dbPath + "data\\WarehouseData.sqlite";
                //string conString = "Data Source=" + countdbPath;

                SQLiteConnection m_dbCountConnection = new SQLiteConnection("Data Source=countdb;Version=3;");
                if (m_dbCountConnection.State != System.Data.ConnectionState.Open)
                {
                    //m_dbCountConnection = con1;
                    m_dbCountConnection.Open();
                    SQLiteCommand cmd1 = new SQLiteCommand();
                    cmd1.Connection = m_dbCountConnection;
                    cmd1.CommandText = "CREATE TABLE countTable3 (count varchar,password varchar)";
                    cmd1.ExecuteNonQuery();
                }               

                SQLiteConnection m_dbMessageConnection = new SQLiteConnection("Data Source=warehousedb;Version=3;");
                if (m_dbMessageConnection.State != System.Data.ConnectionState.Open)
                {
                    //m_dbMessageConnection = con2;
                    m_dbMessageConnection.Open();
                    SQLiteCommand cmd2 = new SQLiteCommand();
                    cmd2.Connection = m_dbMessageConnection;
                    cmd2.CommandText = "CREATE TABLE countTable3 (count varchar,password varchar)";
                    cmd2.ExecuteNonQuery();
                }              
            }
            catch(SQLiteException ex)
            {
                
            }
        }

        public void insertCount(string s1,string s2)
        {
            try
            {
                string sql = "insert into countTable3 (count, password) values (s1,s2)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = m_dbCountConnection;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();               
            }
            catch (SQLiteException ex)
            { }
        }
    }
}
