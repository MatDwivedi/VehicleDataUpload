using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using VehicleDataUpload.Core.Models;

namespace VehicleDataUpload.Core.Helpers
{
    public static class CSVHelper
    {
        
        public static SalesRecord RetrieveFromattedData(string csvLine)
        {
            //string[] values = csvLine.Split(','); //does not work with "," inside strings
            Regex regexExp = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //escape character not working
            string[] values = regexExp.Split(csvLine);

            SalesRecord salesData = new SalesRecord();

            if(!string.IsNullOrEmpty(values[0].Trim()))
                salesData.DealNumber = Convert.ToInt32(values[0].Trim());
            salesData.CustomerName = !string.IsNullOrEmpty(values[1].Trim())?Convert.ToString(values[1].Trim()).Replace("\"", "") : string.Empty;
            salesData.DealershipName = !string.IsNullOrEmpty(values[2].Trim()) ? Convert.ToString(values[2].Trim()).Replace("\"", "") : string.Empty;
            salesData.Vehicle = !string.IsNullOrEmpty(values[3].Trim()) ? Convert.ToString(values[3].Trim()).Replace("\"","") : string.Empty;
            salesData.Price = GetFormattedValue(values[4].Trim());
            salesData.Date = !string.IsNullOrEmpty(values[5].Trim()) ? Convert.ToString(values[5].Trim()) : string.Empty;
            return salesData;
        }

        public static string GetFormattedValue(string toFormat)
        {

            var decimalPrice = !string.IsNullOrEmpty(toFormat) ?
                decimal.Parse(toFormat.Replace("\"", ""), CultureInfo.GetCultureInfo("en-US")) : 0;

            return $"CAD$ {decimalPrice:n0}";
        }

        public static string GetMostSoldVehicle(IList<SalesRecord> salesRecords)
        {
            return salesRecords.GroupBy(v => v.Vehicle)
                .OrderByDescending(s => s.Count())
                .SelectMany(x => x)
                .First()
                .Vehicle;
        }
    }

    
}
