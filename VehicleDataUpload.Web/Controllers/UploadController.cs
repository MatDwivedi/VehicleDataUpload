using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleDataUpload.Core.IServices;
using VehicleDataUpload.Core.Models;

namespace VehicleDataUpload.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IFileManager fileManager;

        public UploadController(IFileManager fileMgr)
        {
            fileManager = fileMgr;
        }

        public ResponseResult Post(IFormFile file)
        {
            ResponseResult result = new ResponseResult();
            //TBD:For every upload, a transaction record can be created to log in the DB
            try
            {
                result.ResponseCode = ResponseCode.FAILED;
                if (!fileManager.IsFileUploaded(file))
                {
                   //TBD:Update transaction log
                    result.ResponseMessage = ApplicationMessage.NoFileUploaded;
                }
                else if (!fileManager.IsFileFormatValid(file.FileName))
                {
                    //TBD:Update transaction log
                    result.ResponseMessage = ApplicationMessage.FileFormatIncorrect;
                }
                else //parse and massage data and return
                {
                    result.fileData = fileManager.ParseData(file);
                    result.ResponseCode = ResponseCode.SUCCEEDED;
                    //TBD:Update transaction log
                }
            }
            catch (Exception ex)
            {
                //TBD:Update transaction log
                result.ResponseMessage = ApplicationMessage.GenericError;
            }

            //TBD:Save transaction log
            return result;
        }
    }
}
