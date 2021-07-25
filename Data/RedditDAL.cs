using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Reddit.Data
{
    public class RedditDAL
    {
        public HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.reddit.com"); ///r/aww/.json
            return client;
        }

        public async Task<RedditModel> GetPostAsync()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync("/r/aww/.json");
            //install-package Microsoft.AspNet.WebAPI.Client
            var redditPost = await response.Content.ReadAsAsync<RedditModel>();
            return redditPost;
        }
    }
}
