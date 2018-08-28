using System;

namespace WebBo.Common
{
    public class Configurations
    {
        public static readonly Configurations Instance = new Configurations();


        public string DbConnectionString { get; set; }



    }
}
