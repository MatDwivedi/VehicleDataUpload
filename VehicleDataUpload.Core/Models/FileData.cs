using System.Collections.Generic;

namespace VehicleDataUpload.Core.Models
{
    public class FileData
    {
        public IList<string> Headers { get; set; }
        public IList<SalesRecord> DataRecords { get; set; }
        public string MostSoldVehicle { get; set; }
    }
}
