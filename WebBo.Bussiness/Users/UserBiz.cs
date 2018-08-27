using System;
using System.Collections.Generic;
using System.Text;
using WebBo.Bussiness.BizModels;

namespace WebBo.Bussiness.Users
{
    public class UserBiz
    {
        public UserModel CheckUser(string userName,string password)
        {
            return new UserModel
            {
                UserId = 1,
                UserName = userName,
                Password = password,
                UserLevel = 99
            };
        }




    }
}
