using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    public class SSEController : Controller
    {
        // GET: api/SSE
        private readonly ISseRepository _sseRepository;

        public SSEController(ISseRepository sseRepository)
        {
            _sseRepository = sseRepository;
        }
        [HttpGet]
        public async Task CreateConnect()
        {
            var response = Response;
            response.Headers.Add("Content-Type", "text/event-stream");

            while (true)
            {
                await response.WriteAsync(_sseRepository.ProductSseData());
                response.Body.Flush();
                await Task.Delay(10 * 1000);//10秒钟发送一次
            }
        }
    }
}
