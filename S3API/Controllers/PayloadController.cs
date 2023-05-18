using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gigz_API.Models;
using Microsoft.AspNetCore.Mvc;
using S3API.Models;

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
        [HttpPost]
        public async Task<IActionResult> PostPayloadAsync(Payload payload)
        {
            try
            {
                //Receive the payload data
                PayloadData  payloadData= payload.Data;
                // Store the payload information in the database
                _context.PayloadData.Add(payloadData);
                await  _context.SaveChangesAsync();
                return Ok(new {message = "Received payload and successfully saved." });
            
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate response
                 throw new ApplicationException("An error occurred while processing the request.");
            }
        }
    }
}
