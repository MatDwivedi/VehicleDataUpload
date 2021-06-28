using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using VehicleDataUpload.Core;
using VehicleDataUpload.Core.Models;

namespace VehicleDataUpload.Core.IServices
{
    public interface IFileManager
    {
        Boolean IsFileFormatValid(string fileName);
        Boolean IsFileUploaded(IFormFile file);

        FileData ParseData(IFormFile file);
    }
}
