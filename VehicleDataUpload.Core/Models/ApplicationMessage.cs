using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDataUpload.Core.Models
{
    public static class ApplicationMessage
    {
        public const string FileFormatIncorrect = "File format not supported!";
        public const string NoFileUploaded = "No File Uploaded!";
        public const string GenericError = "Error uploading/ parsing file data. Please try again later.";
    }
}
