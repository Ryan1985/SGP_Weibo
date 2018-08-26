using Newtonsoft.Json;
using System;
using System.Text;
using WebBo.Bussiness.Http;

namespace WebBo.Bussiness.Api
{
    public class ApiAdapter
    {
        public static readonly ApiAdapter Instance = new ApiAdapter();

        private ApiAdapter() { }


        public ApiOperationFailResultModel Post(string url,ApiParamModel model)
        {
            var sbUrl = new StringBuilder($"{url}?");
            sbUrl.Append($"apikey={model.ApiKey}");
            sbUrl.Append($"&link={model.Link}");
            sbUrl.Append($"&num={model.Num}");
            sbUrl.Append($"&type={model.Type}");
            sbUrl.Append($"&author={model.Author}");
            if (!string.IsNullOrEmpty(model.Comment))
                sbUrl.Append($"&comment={model.Comment}");
            sbUrl.Append($"&contenttype={model.ContentType}");
            if (!string.IsNullOrEmpty(model.ridlink))
                sbUrl.Append($"&ridlink={model.ridlink}");

            var result  = NetHelper.Post(sbUrl.ToString());
            var resultObj = JsonConvert.DeserializeObject<ApiOperationFailResultModel>(result);
            return resultObj;
        }


    }
}
