using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using WebBo.Bussiness.BizModels;
using WebBo.Bussiness.Extensions;
using WebBo.Common;

namespace WebBo.Bussiness.DataAccess
{
    public class FctUser: DataAccessClass
    {
        public FctUser() : base(Configurations.Instance.DbConnectionString) { }
        
        public UserModel GetUser(int userId)
        {
            var parameters = base.BuildParameters(new Hashtable
            {
                {"userId",userId }
            });
            var sql = @"SELECT user_id,login_name,login_password,user_level,user_name,mobile,account_status,create_time,last_update_time  FROM weibo.fct_user where id = ?userId";
            var dtUser = base.GetDataTable(sql, parameters);
            return new UserModel
            {
                Password = dtUser.Rows[0]["login_password"].ToString(),
                UserId = dtUser.Rows[0]["user_id"].To<int>(),
                UserLevel = dtUser.Rows[0]["user_level"].To<int>(),
                UserName = dtUser.Rows[0]["user_name"].ToString()
            };
        }

        public UserModel GetUser(string loginName,string password)
        {
            var parameters = base.BuildParameters(new Hashtable
            {
                {"loginName",loginName },
                {"userPassword",password }
            });
            var sql = @"SELECT user_id,login_name,login_password,user_level,user_name,mobile,account_status,create_time,last_update_time  FROM weibo.fct_user where login_name = ?loginName and login_password = ?userPassword";
            var dtUser = base.GetDataTable(sql, parameters);
            return new UserModel
            {
                Password = dtUser.Rows[0]["login_password"].ToString(),
                UserId = dtUser.Rows[0]["user_id"].To<int>(),
                UserLevel = dtUser.Rows[0]["user_level"].To<int>(),
                UserName = dtUser.Rows[0]["user_name"].ToString()
            };
        }
    }
}
