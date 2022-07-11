using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OcelotGateway.Handle
{
    public class BlackListHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //var myHeader = request.Headers.FirstOrDefault
            //request.Headers.AcceptEncoding.Clear();
            //return await base.SendAsync(request, cancellationToken);
            return null;
        }
    }
}
