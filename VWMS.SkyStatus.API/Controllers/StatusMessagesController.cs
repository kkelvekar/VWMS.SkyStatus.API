using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VWMS.SkyStatus.API;
using VWMS.SkyStatus.API.Entities;
using VWMS.SkyStatus.API.Models;
using VWMS.SkyStatus.API.Services;

namespace VWMS.SkyStatus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusMessagesController : ControllerBase
    {
        private readonly StatusMessageService service;

        public StatusMessagesController(StatusMessageService service)
        {
            this.service = service;
        }


        [HttpPost]
        [Route("ReceiveStatusMessage")]
        public IActionResult ReceiveStatusMessage([FromBody] StatusMessageDto statusMessageDto)
        {
            if (statusMessageDto == null)
            {
                return BadRequest(new { message = "Invalid XML data" });
            }

            // Process the status message
            service.ProcessStatusMessage(statusMessageDto);

            return Ok(new { message = "Data received and saved successfully" });
        }


    }
}
