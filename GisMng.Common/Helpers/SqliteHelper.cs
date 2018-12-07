using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static async Task<IEnumerable<T>> GetAllAsync<T>() where T : class, new()
        {
            Open();
            return await _sqlLiteConnection.GetAllAsync<T>();
        }
        /// <summary>
        /// 根据id获取信息
        /// </summary>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(int id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            Open();
            return await _sqlLiteConnection.GetAsync<T>(id);
        }
        /// <summary>
        /// 根据id获取信息
        /// </summary>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(string id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            Open();
            return await _sqlLiteConnection.GetAsync<T>(id);
        }
        /// <summary>
        /// 根据id获取信息
        /// </summary>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(Guid id, IDbTransaction transaction = null, int? commandTimeout = null) where T : class, new()
        {
            Open();
            return await _sqlLiteConnection.GetAsync<T>(id);
        }
    }
}
