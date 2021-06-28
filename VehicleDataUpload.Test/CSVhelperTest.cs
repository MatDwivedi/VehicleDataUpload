using System;
using System.Collections.Generic;
using System.Text;
using VehicleDataUpload.Core.Helpers;
using VehicleDataUpload.Core.Models;
using Xunit;

namespace VehicleDataUpload.Test
{
    public class CSVhelperTest
    {
        [Fact]
        public void ShouldGetMostSoldVehicle()
        {
            var feedData = new List<SalesRecord>();
            feedData.Add(new SalesRecord { Vehicle = "2018 Honda Civic" });
            feedData.Add(new SalesRecord { Vehicle = "2020 Hyndai Elantra" });
            feedData.Add(new SalesRecord { Vehicle = "2018 Honda Civic" });
            feedData.Add(new SalesRecord { Vehicle = "2018 Honda CRV" });
            feedData.Add(new SalesRecord { Vehicle = "2018 Honda Civic" });

            var actual = CSVHelper.GetMostSoldVehicle(feedData);

            Assert.Equal("2018 Honda Civic", actual);
        }
    }
}
