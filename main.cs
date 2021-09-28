using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;



    public class API_Response
    {
				public int id { get; set; }
        public int xp { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // request params
            string apiUrl = "https://perrycreativetech.com/wp-json/xp/check";
						
            // make http post request
            string response = Http.Post(apiUrl, new NameValueCollection()
            {
                { "username", "Jeffrey"                                    },
                { "password", "Bumblebee0604" }
            });
						}
						
						

            // decode json string to dto object
            API_Response r = 
                JsonConvert.DeserializeObject<API_Response>(response);
						Console.WriteLine("ID:");
						Console.WriteLine(r.id);
						Console.WriteLine("---");
						Console.WriteLine("XP:");
						Console.WriteLine(r.xp);
						
						

    }

    public static class Http
    {
        public static String Post(string uri, NameValueCollection pairs)
        {
            byte[] response = null;
            using (WebClient client = new WebClient())
            {
                response = client.UploadValues(uri, pairs);
								
            }

            return Encoding.Default.GetString(response);
        }
    }
		}

