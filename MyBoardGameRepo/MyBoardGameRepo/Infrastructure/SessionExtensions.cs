using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MyBoardGameRepo.Infrastructure
{
    public static class SessionExtensions
    {
        //   F i e l d s   &   P r o p e r t i e s

        //   C o n s t r u c t o r s

        //   M e t h o d s

        public static T GetJson<T>(this ISession session, string key)
        {
            string sessionJsonString = session.GetString(key);
            if (sessionJsonString == null)
            {
                return default(T);
            }

            T result = JsonConvert.DeserializeObject<T>(sessionJsonString);
            return result;
        }

        public static void SetJson(this ISession session, string key, object value)
        {
            string valueJsonString = JsonConvert.SerializeObject(value);
            session.SetString(key, valueJsonString);
        }
    }
}
