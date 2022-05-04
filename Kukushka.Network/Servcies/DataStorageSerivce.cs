using LiteDB;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Servcies
{
    public class DataStorageSerivce : IDataStorageSerivce
    {
        private ILiteStorage<Guid> _storage;

        public DataStorageSerivce(ILiteDatabase db)
        {
            _storage = db.GetStorage<Guid>("_data");
        }

        public LiteFileInfo<Guid> GetFileInfo(Guid id)
        {
            return _storage.FindById(id);
        }

        public async Task<LiteFileInfo<Guid>> UploadFile(Stream stream, string fileName)
        {
            var fileStream = _storage.OpenWrite(Guid.NewGuid(), fileName);
            await stream.CopyToAsync(fileStream);
            fileStream.Close();
            return fileStream.FileInfo;
        }
    }
}
