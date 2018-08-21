using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web.Mvc;

namespace VueJsAspNetMVC
{
    public static class Vue
    {
        public static MvcHtmlString Encode(object Value)
        {
            return new MvcHtmlString(JsonConvert.SerializeObject(Value, new JavaScriptDateTimeConverter()));
        }
    }
}