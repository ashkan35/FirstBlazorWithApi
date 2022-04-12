﻿using Application.Models.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Model;
using WebFramework.BaseController;

namespace Web.Api.Controllers.V1
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Hotel")]
    public class HotelController : BaseController
    {
        [HttpGet("GetCounter")]
        [AllowAnonymous]
        public async Task<IActionResult> GetCounter()
        {
            var counter = new Counter{Name = "Count", Value = 2232};
            return Ok(counter);
        }
    }
}
