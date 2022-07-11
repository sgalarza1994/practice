using OcelotGateway.Handle;
using Ocelot.Middleware;
using Ocelot;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace OcelotGateway.Handle
{
    public class RemoveEncodinnDelegateHandle : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,CancellationToken cancellationToken)
        {
            request.Headers.AcceptEncoding.Clear();
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
