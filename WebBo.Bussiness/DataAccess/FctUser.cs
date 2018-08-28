using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebBo.Bussiness.DataAccess
{
    public class FctUser: DataAccessClass
    {
        public FctUser(string connectionString) : base(connectionString) { }



        public void GetUser(int userId)
        {
            var parameters = base.BuildParameters(new Hashtable
            {
                {"userId",userId }
            });
            var sql = @"SELECT * FROM weibo.fct_user where id = ?userId";
            var dtUser = base.GetDataTable(sql, parameters);
            


        }
    }
}
