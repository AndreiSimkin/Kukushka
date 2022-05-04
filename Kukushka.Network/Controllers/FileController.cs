using Kukushka.Network.Commands.Files;
using Kukushka.Network.Queries.Files;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ISender _sender;
        public FileController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var request = new UploadFileCommand(file);

            var result = await _sender.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IActionResult> DownloadFile(Guid id)
        {
            var request = new GetFileQueiry(id);

            var result = await _sender.Send(request);

            return result;
        }
    }
}
