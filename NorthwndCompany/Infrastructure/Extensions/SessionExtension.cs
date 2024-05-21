using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace NorthwndCompany.Infrastructure.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string jsonData = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonData);
        }

        public static T GetObject<T>(this ISession session,string key)
        {
            string value = session.GetString(key);

            if(value != null)
            {
                T data = JsonConvert.DeserializeObject<T>(value);
                return data;
            }

            return default(T);
        }
    }
}
