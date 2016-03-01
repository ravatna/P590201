using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
namespace OfficeSupport
{
    class DbManager
    {

        public static int MODE_VIEW = 0;
        public static int MODE_EDIT = 1;
        public static int MODE_ADD = 2;

        public static int ACTION_SAVE = 0;
        public static int ACTION_UPDATE = 1;
        public static int ACTION_DELETE = 2;
        public static int ACTION_QUERY = 3;


        public static String StrConnection = ConfigurationManager.ConnectionStrings["local"].ConnectionString.ToString();


        /// <summary>
        /// เปลียนแปลงข้อมูลด้วย INSERT UPDATE DELETE และคืนค่าจำนวนข้อมูลที่มีผลกระทบ
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExcuteNonQuery(String sql)
        {


            // New object Sql Connection.
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StrConnection;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // Create and prepare an SQL statement.
            SqlCommand _cmd = new SqlCommand(sql, conn);
            int result = _cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        /// <summary>
        /// เปลียนแปลงข้อมูลด้วย INSERT UPDATE DELETE และคืนค่าจำนวนข้อมูลที่มีผลกระทบ
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExcuteNonQuery(SqlCommand cmd)
        {


            // New object Sql Connection.
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StrConnection;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.Connection = conn;
            cmd.Prepare();

            //MessageBox.Show(cmd.CommandText);
            

            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }



        /// <summary>
        /// เรียกค้นข้อมูลและคืนค่ากลับมาเป็น Data Reader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static  SqlDataReader ExcuteQuery(SqlCommand cmd)
        {


            // New object Sql Connection.
            SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString = StrConnection;
            cmd.Connection = conn;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            //MessageBox.Show(cmd.CommandText);
            // Create and prepare an SQL statement.
            //cmd.Prepare();
            SqlDataReader rd = cmd.ExecuteReader();
            conn.Close();
            return rd;
        }

        /// <summary>
        /// เรียกค้นข้อมูลและคืนค่ากลับมาเป็น Data Adapter
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>

        public static SqlDataReader ExcuteQuery(String sql)
        {

            // New object Sql Connection.
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StrConnection;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // Create and prepare an SQL statement.
            SqlCommand  cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            conn.Close();

            return dr;
        }

     

        /// <summary>
        /// เรียกค้นข้อมูลและคืนค่ากลับมาเป็น Data Adapter
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>

        public static DataSet ExcuteQuery(String sql, String dsName)
        {


            // New object Sql Connection.
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = StrConnection;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // Create and prepare an SQL statement.
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds,dsName);
            conn.Close();
            
            return ds;
        }

        public static String getDeleteSQL(String tableName ) {
            return "DELETE FROM " + tableName ;
        }

        public static String getDeleteSQL(String tableName ,String whereCourse) {
            return "DELETE FROM " + tableName + " WHERE " + whereCourse;
        }


        public static String getSelectSQL(String tableName, String[] fieldName)
        {

            String joined = string.Join(",", fieldName);
            
            return "SELECT " + joined+ " FROM " + tableName ;
        }

        public static String getSelectSQL(String tableName, String[] fieldName,string Where)
        {

            String joined = string.Join(",", fieldName);

            return "SELECT " + joined + " FROM " + tableName + " WHERE " + Where;
        }

        public static String getInsertSQL(String tableName,String[] fieldName)
        {
           
            String joined = string.Join(",",fieldName);
            String valueJoined = "";
           
            for(int i =0; i< fieldName.Length; i++){
                valueJoined += "@" + fieldName[i];
                if (!(fieldName.Length == (i + 1))) {
                    valueJoined += ",";
                }
            }

            return "INSERT INTO " + tableName + "("  + joined +") VALUES ("+ valueJoined +")";
        }

       
        public static String getUpdateSQL(String tableName, String[] fieldName, String whereCourse)
        {


            String valueJoined = "";// string.Join(",", fieldName);

            for (int i = 0; i < fieldName.Length; i++)
            {
                valueJoined += fieldName[i] + "=@" + fieldName[i];
                if (!(fieldName.Length == (i + 1)))
                {
                    valueJoined += ",";
                }
            }

            return "UPDATE " + tableName + " SET " + valueJoined + " WHERE " + whereCourse;
        }
        
    }
}
