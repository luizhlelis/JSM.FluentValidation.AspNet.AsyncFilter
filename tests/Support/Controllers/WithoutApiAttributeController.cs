﻿using JSM.FluentValidation.AspNet.AsyncFilter.Tests.Support.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JSM.FluentValidation.AspNet.AsyncFilter.Tests.Support.Controllers
{
    [Route("[controller]")]
    public class WithoutApiAttributeController : ControllerBase
    {
        [HttpGet("test-validator")]
        public IActionResult Get([FromQuery] TestPayload request) => Ok();

        [HttpPost("test-validator")]
        public IActionResult Post([FromBody] TestPayload request) => Ok();

        [HttpPost("test-validator-collection")]
        public IActionResult PostCollection([FromBody] IEnumerable<TestPayload> request) => Ok();

        [HttpPost("without-validation")]
        public IActionResult Post([FromBody] TestPayloadWithoutValidation request) => Ok();
        
        [HttpGet("user-test-validator")]
        public IActionResult Get([FromQuery] TestUser request) => Ok();
    }
}
