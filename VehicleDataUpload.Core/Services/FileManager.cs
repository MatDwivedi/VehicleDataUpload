using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using VehicleDataUpload.Core.Helpers;
using VehicleDataUpload.Core.IServices;
using VehicleDataUpload.Core.Models;

namespace VehicleDataUpload.Core.Services
{
    public class FileManager : IFileManager
    {
        public Boolean IsFileFormatValid(string fileName)
        {
            return (fileName.EndsWith(".csv", true, null));
        }

        public Boolean IsFileUploaded(IFormFile file)
        {
            return (file != null);
        }

        public FileData ParseData(IFormFile file)
        {
            FileData fileData = new FileData();
            var parsedData = new List<SalesRecord>();

            int cnt = 0;
            //var reader = new StreamReader(file.OpenReadStream());
            var reader = new StreamReader(file.OpenReadStream(), Encoding.GetEncoding("iso-8859-1"));
            while (reader.Peek() >= 0)
            {
                //Assuming first row is going to be the header, more validataion can be added to verify header
                if (cnt == 0)
                {
                    fileData.Headers = reader.ReadLine().Split(",").ToList();
                }
                else
                {
                    SalesRecord salesRecord = CSVHelper.RetrieveFromattedData(reader.ReadLine());
                    parsedData.Add(salesRecord);
                }
                cnt++;
            }
            fileData.DataRecords = parsedData;
            fileData.MostSoldVehicle = CSVHelper.GetMostSoldVehicle(parsedData);
            return fileData;
        }
    }


}