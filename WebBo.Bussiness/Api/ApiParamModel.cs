using System;
using System.Collections.Generic;
using System.Text;

namespace WebBo.Bussiness.Api
{
    //http://api.ekai03.cn/api/create.asp?apikey=961b1d975f0e6c1b9b3463867cd1cb37&link=https://weibo.com/1932379431/G0GbZexxB&num=100&type=12&author=false&comment=aaa&contenttype=2
    public class ApiParamModel
    {
        public string ApiKey { get; set; }
        public string Link { get; set; }
        public int Num { get; set; }
        public int Type { get; set; }
        public bool Author { get; set; }
        public string Comment { get; set; }
        public int ContentType { get; set; }
        public string ridlink { get; set; }
    }
}
