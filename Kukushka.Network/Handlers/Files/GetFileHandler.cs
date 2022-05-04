using Kukushka.Network.Queries.Files;
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
    public class GetFileHandler : IRequestHandler<GetFileQueiry, IActionResult>
    {
        private IDataStorageSerivce _storageService;

        public GetFileHandler(IDataStorageSerivce storageSerivce)
        {
            _storageService = storageSerivce;
        }

        public async Task<IActionResult> Handle(GetFileQueiry request, CancellationToken cancellationToken)
        {
            var fileInfo = _storageService.GetFileInfo(request.Id);

            return new FileStreamResult(fileInfo.OpenRead(), fileInfo.MimeType);
        }
    }
}
