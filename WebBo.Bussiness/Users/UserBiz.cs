using System;
using System.Collections.Generic;
using System.Text;
using WebBo.Bussiness.BizModels;
using WebBo.Bussiness.DataAccess;

namespace WebBo.Bussiness.Users
{
    public class UserBiz
    {
        FctUser fctUser = new FctUser();


        public UserModel CheckUser(string userName,string password)
        {
            var user =  fctUser.GetUser(userName, password);
            return user;
        }




    }
}
