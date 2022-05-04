using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Commands.Files
{
    public class UploadFileCommand : IRequest<IActionResult>
    {
        public UploadFileCommand(IFormFile file)
        {
            File = file;
        }

        public IFormFile File { get; set; }
    }
}
