using RestSharp;

namespace APIRedditLabJT.Models
{
    public class RedditAPIDAL
    {
        public RJSON GetPost()
        {
            var client = new RestClient($"https://www.reddit.com/r/aww/.json");
            var request = new RestRequest();
            var response = client.GetAsync<RJSON>(request);
            RJSON rj = response.Result;
            return rj;
        }

    }
}
