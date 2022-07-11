using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OcelotGateway.Aggegator
{
    public class UsersPostsAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var userResponseContent = await responses[0].Items.DownstreamResponse().Content.ReadAsStringAsync();
            var postResponseConte = await responses[1].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var user = JsonConvert.DeserializeObject<object>(userResponseContent);
            var posts = JsonConvert.DeserializeObject<List<object>>(userResponseContent);


            //var userPost = posts.Where(s =>);
            return null;
        }
    }
}
