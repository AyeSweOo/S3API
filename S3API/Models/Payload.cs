using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S3API.Models
{
    public class Payload
    {
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string GroupId { get; set; }
        public string DataType { get; set; }
        public PayloadData Data { get; set; }
        public long Timestamp { get; set; }
    }
    public class PayloadData
    {
        // Add properties based on the payload data structure
        [Key]
        public int Id { get; set; }
        public bool FullPowerMode { get; set; }
        public bool ActivePowerControl { get; set; }
        public int FirmwareVersion { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool Occupancy { get; set; }
    }
}
