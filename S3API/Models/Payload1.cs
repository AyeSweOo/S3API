using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S3API.Models
{
    public class Payload1
    {
        public string deviceId { get; set; }
        public string deviceType { get; set; }
        public string deviceName { get; set; }
        public string droupId { get; set; }
        public string dataType { get; set; }
        public PayloadData1 data { get; set; }
        public long timestamp { get; set; }
    }

    public class PayloadData1
    {
        // Add properties based on the payload data structure
        [Key]
        public int Id { get; set; }
        public bool fullPowerMode { get; set; }
        public bool activePowerControl { get; set; }
        public int firmwareVersion { get; set; }
        public int temperature { get; set; }
        public int humidity { get; set; }
      
    }
   
}
