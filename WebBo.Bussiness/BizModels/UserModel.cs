using System;
using System.Collections.Generic;
using System.Text;

namespace WebBo.Bussiness.BizModels
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserLevel { get; set; }
    }
}
