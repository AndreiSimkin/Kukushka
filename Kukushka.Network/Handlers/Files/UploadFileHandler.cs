using Kukushka.Network.Commands.Files;
using Kukushka.Network.Servcies;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Kukushka.Network.Handlers.Files
{
    public class UploadFileHandler : IRequestHandler<UploadFileCommand, IActionResult>
    {
        private IDataStorageSerivce _storageService;

        public UploadFileHandler(IDataStorageSerivce storageSerivce)
        {
            _storageService = storageSerivce;
        }

        public async Task<IActionResult> Handle(UploadFileCommand request, CancellationToken cancellationToken)
        {
            var result = await _storageService.UploadFile(request.File.OpenReadStream(), request.File.FileName);
            return new OkObjectResult(result.Id);
        }
    }
}
