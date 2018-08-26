using System;
using System.Collections.Generic;
using System.Text;

namespace WebBo.Bussiness.Api
{
    public class ApiOperationSuccessResultModel: ApiResultModel
    {
        public decimal cost { get; set; }
        public ApiOperationSuccessMsg msg { get; set; }
    }

    public class ApiOperationSuccessMsg
    {
        public int ret { get; set; }
        public long orderid { get; set; }
        public string msg { get; set; }
    }


}
