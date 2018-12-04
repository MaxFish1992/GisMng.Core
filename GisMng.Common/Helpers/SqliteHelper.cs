using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace GisMng.Common.Helpers
{
    /// <summary>
    /// 功能描述    ：SqliteHelper  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:35:48 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:35:48 
    /// </summary>
    public class SqliteHelper
    {
        private static SQLiteConnection _sqlLiteConnection = null;
        private static string _baseDirectory = AppDomain.CurrentDomain.BaseDirectory + @"GisMng.db";

        private static void Open()
        {
            if (_sqlLiteConnection == null)
            {
                _sqlLiteConnection = new SQLiteConnection();
            }
            _sqlLiteConnection.ConnectionString = string.Format("Data Source={0}", _baseDirectory);
            _sqlLiteConnection.Open();
        }
        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        public static List<T> QueryAll<T>(string sql)
        {
            Open();
            List<T> users = new List<T>();
            users = _sqlLiteConnection.Query<T>(sql) as List<T>;
            _sqlLiteConnection.Close();
            return users;
        }
        /// <summary>
        /// 根据id获取信息
        /// </summary>
        /// <returns></returns>
        public static T Query<T>(string sql)
        {
            Open();
            List<T> users = new List<T>();
            users = _sqlLiteConnection.Query<T>(sql) as List<T>;
            _sqlLiteConnection.Close();
            return users.First<T>();
        }
    }
}
