using System;

namespace VehicleDataUpload.Core.Models
{
    public class SalesRecord
    {

        public Int64? DealNumber { get; set; }
        public string CustomerName { get; set; }
        public string DealershipName { get; set; }
        public string Vehicle { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
    }
}
