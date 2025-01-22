using Newtonsoft.Json;

namespace MvcClientApi.Services
{
    public class RespContent
    {
        public string access_token;
        public string username;
    }
    public class LoginService
    {
        HttpClient client;
        string serviceUrl;

        public LoginService()
        {
            client = new HttpClient();
            serviceUrl = @"http://localhost:5223/token?username=admin@gmail.com&password=12345";
        }

        public string GetToken()
        {
            var resp = client.PostAsync(serviceUrl, null).Result;
            var result = resp.Content.ReadAsStringAsync().Result;
            var token = JsonConvert.DeserializeObject<RespContent>(result);
            return token.access_token;
        }


    }
}
