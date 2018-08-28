using System;
using System.Collections.Generic;
using System.Text;

namespace WebBo.Bussiness.Extensions
{
    public static class BizExtensions
    {
        public static T To<T>(this object obj,T defaultValue = default(T) )
        {
            if (obj==null || Convert.IsDBNull(obj))
            {
                return defaultValue;
            }
            
            T entity = (T)Convert.ChangeType(obj, typeof(T));
            return entity;

        }
    }
}
