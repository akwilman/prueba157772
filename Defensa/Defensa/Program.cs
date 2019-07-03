using Defensa.Business;
using Defensa.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defensa
{
    class Program
    {
        static void Main(string[] args)
        {

            Reading myReading = new Reading()
            {
                Value = 1
            };

            Location location = new Location()
            {
                Latitude = 5,
                Longitude = 6
            };

            List<Reading> readings = new List<Reading>();
            readings.Add(myReading);

            Device myDevice = new Device
            {
                Name = "asdasdasd",
                Location = location,
                Reads = readings
            };


            using (var context = new EntityContext())
            {
                context.Devices.Add(myDevice);
                int deviceId = context.SaveChanges();


                var deviceToUpdate = context.Devices.FirstOrDefault(e => e.Id == deviceId);
                deviceToUpdate.Name = "updated";

                context.Entry(deviceToUpdate).State = EntityState.Modified;

                context.SaveChanges();


                context.Devices.Remove(myDevice);

                context.SaveChanges();

            }
        }
    }
}
