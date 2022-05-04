using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Queries.Files
{
    public class GetFileQueiry : IRequest<IActionResult>
    {
        public GetFileQueiry(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
