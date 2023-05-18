using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S3API.Models
{
    public class Payload2
    {
        public string deviceId { get; set; }
        public string deviceType { get; set; }
        public string deviceName { get; set; }
        public string groupId { get; set; }
        public string dataType { get; set; }
        public PayloadData2 data { get; set; }
        public long timestamp { get; set; }
    }
    public class PayloadData2
    {
        // Add properties based on the payload data structure
        [Key]
        public int id { get; set; }
        public int version { get; set; }
        public string messageType { get; set; }
        public int firmwareVersion { get; set; }
        public int stateChanged { get; set; }
  
        public bool occupancy { get; set; }
    }
}
