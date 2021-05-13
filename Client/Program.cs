using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        private static async Task Main()
        {
            try
            {
                // discover endpoints from metadata
                var client = new HttpClient();
                //var ids4Url = "http://101.200.182.225:53362";
                //// discover endpoints from metadata
                //var discoveryClient = new DiscoveryClient(ids4Url) { Policy = { RequireHttps = false } };
                //var disco = await discoveryClient.GetAsync();
                var disco = await client.GetDiscoveryDocumentAsync("http://localhost:53362") ;
                if (disco.IsError)
                {
                    Console.WriteLine(disco.Error);
                    return;
                }

                //request token
                var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                {
                    Address = disco.TokenEndpoint,
                    ClientId = "business-app",
                    ClientSecret = "1q2w3e*",

                    Scope = "InternalGateway BaseService"
                });

                if (tokenResponse.IsError)
                {
                    Console.WriteLine(tokenResponse.Error);
                    return;
                }

                Console.WriteLine(tokenResponse.Json);
                Console.WriteLine("\n\n");

                //// call api
                //var apiClient = new HttpClient();
                //apiClient.SetBearerToken(tokenResponse.AccessToken);

                //var response = await apiClient.GetAsync("http://localhost:51186/api/app/cs-machine-shift-report");
                //if (!response.IsSuccessStatusCode)
                //{
                //    Console.WriteLine(response.StatusCode);
                //}
                //else
                //{

                //    //var content = await response.Content.ReadAsStringAsync();
                //    ////Console.WriteLine(content);
                //    //string baseAddr = "http://localhost:51186";
                //    //string path = "http://localhost:51186/BusinessService"; //"Bearer " + tokenResponse.AccessToken;
                //    //string auth = "Bearer " + tokenResponse.AccessToken;
                //    //HttpFactory httpFactory = new HttpFactory();
                //    //AbsHttpHelper helper = httpFactory.CreateHttpHelper("post", baseAddr, auth, path, true, null);
                //    //string rs = helper.GetResult();
                //    //Console.WriteLine(rs);


                //}
                using (var httpClient = new HttpClient())
                {
                    httpClient.SetBearerToken(tokenResponse.AccessToken);
                    var response1 = await httpClient.GetAsync("http://localhost:51186/api/business/lt-machine-shift-report");
                    //var response1 = await httpClient.GetAsync("http://localhost:51186/api/business/lt-machine-shift-report");
                    if (response1.IsSuccessStatusCode)
                    {
                        System.Console.WriteLine(await response1.Content.ReadAsStringAsync());
                    }
                    else
                    {
                        Console.WriteLine(response1.StatusCode);
                    }
                }


                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }


    }
}
