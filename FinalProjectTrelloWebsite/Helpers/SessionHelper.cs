using System;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace FinalProjectTrelloWebsite.Controllers.Helpers
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
