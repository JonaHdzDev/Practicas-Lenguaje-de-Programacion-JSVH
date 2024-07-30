using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;


namespace Conexion1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<OUT> list = GithubApi();

            //Console.WriteLine(list[0].message, list[1].documentation_url, list[2].status);

            List<Cuenta> cuenta = GithubApi();

            Console.WriteLine(cuenta[3].login, cuenta[4].id, cuenta[5].node_id, cuenta[6].avatar_url, cuenta[7].gravatar_id, cuenta[8].url, cuenta[9].html_url, cuenta[10].followers_url, 
                cuenta[11].following_url, cuenta[12].gists_url, cuenta[13].starred_url, cuenta[14].subscriptions_url, cuenta[15].organizations_url, cuenta[16].repos_url, cuenta[17].events_url, 
                cuenta[18].received_events_url, cuenta[19].type, cuenta[20].site_admin, cuenta[21].name, cuenta[22].company, cuenta[23].blog, cuenta[24].location, cuenta[25].email, 
                cuenta[26].hireable, cuenta[27].bio, cuenta[28].twitter_username, cuenta[29].public_repos, cuenta[30].public_gists, cuenta[31].followers, cuenta[32].following, 
                cuenta[33].created_at);
        }

        public static List<Cuenta> GithubApi()
        {
            try
            {
                using (RestClient client = new RestClient("https://api.github.com/users/%3CJonaHdzDev%3E"))
                {
                    RestRequest request = new RestRequest();
                    string respuesta;
                    var response = client.Get(request);
                    respuesta = response.Content;

                    List<Cuenta> salida = JsonConvert.DeserializeObject<List<Cuenta>>(respuesta);

                    return salida;
                }
            }
            catch
            {
                List<Cuenta> salida = new List<Cuenta>();
                return salida;
            }

        }
    }
}