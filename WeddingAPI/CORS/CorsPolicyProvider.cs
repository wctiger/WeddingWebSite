using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace WeddingAPI.CORS
{
    public class CorsPolicyProvider : ICorsPolicyProvider
    {
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult((CorsPolicy)new MyCorsPolicy());
        }
    }

    public class MyCorsPolicy : CorsPolicy
    {
        public MyCorsPolicy()
        {
            AllowAnyHeader = true;
            Methods.Add(HttpMethod.Post.ToString());
            Origins.Add("localhost");
            Origins.Add("http://localhost:56805");
        }
    }
}