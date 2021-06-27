using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task7.Core.Repositories;
using Task7.Core.Services;

namespace Task7.Web.Controllers
{
    [Route("handle/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        private readonly ILinkService _linkService;
        public TaskController(ILinkService linkService)
        {
            _linkService = linkService;
        }
        [HttpGet]
        public async Task<IActionResult> InsertEntity()
        {
            var MyUrl = Request.Path.Value;
            //var s = await _linkService.CreateShortLink("https://google.com", MyUrl.ToString());
            //await _linkService.IncreaseTransitionCount("forms/58e0c36fed074222b2fa");
            return Ok();
        }
    }
}