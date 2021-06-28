namespace VehicleDataUpload.Core.Models
{
    public class ResponseResult
    {
        public ResponseCode ResponseCode { get; set; }
        public FileData fileData { get; set; }
        public string ResponseMessage { get; set; }
    }

        public enum ResponseCode
        {
            SUCCEEDED = 0,
            FAILED = 1
        }
 }
