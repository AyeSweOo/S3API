using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using S3API.Models;
using Microsoft.AspNetCore.Mvc;
namespace S3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayloadController : ControllerBase
    {
       private readonly APIDbContext _context;
        [Obsolete]
        public PayloadController(APIDbContext context)
        {
            _context = context;
        
        }
        [Route("[action]")]
        [HttpPost]
        [ActionName("savePayload1")]
        public async Task<IActionResult> PostPayload1Async(Payload1 payload1)
        {
            try
            {
                //Receive the payload data
                PayloadData1  payloadData1= payload1.data;
                // Store the payload information in the database
                _context.PayloadData1.Add(payloadData1);
                await  _context.SaveChangesAsync();
                return Ok(new {message = "Received payload and successfully saved." });
            
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate response
                 throw new ApplicationException("An error occurred while processing the request.");
            }
        }
        [Route("[action]")]
        [HttpPost]
        [ActionName("savePayload2")]
        public async Task<IActionResult> PostPayload2Async(Payload2 payload2)
        {
            try
            {
                //Receive the payload data
                PayloadData2 payloadData2 = payload2.data;
                // Store the payload information in the database
                _context.PayloadData2.Add(payloadData2);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Received payload and successfully saved." });

            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate response
                throw new ApplicationException("An error occurred while processing the request.");
            }
        }
    }
}
