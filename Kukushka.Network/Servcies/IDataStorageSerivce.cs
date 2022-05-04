using LiteDB;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Kukushka.Network.Servcies
{
    public interface IDataStorageSerivce
    {
        LiteFileInfo<Guid> GetFileInfo(Guid id);
        Task<LiteFileInfo<Guid>> UploadFile(Stream stream, string fileName);
    }
}