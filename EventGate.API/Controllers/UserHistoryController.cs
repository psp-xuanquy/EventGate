﻿using EventGate.Business.Services;
using EventGate.Business.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EventGate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserHistoryController : Controller
    {
        private readonly IUserHistoryService _userHistoryService;

        public UserHistoryController(IUserHistoryService userHistoryService)
        {
            _userHistoryService = userHistoryService;
        }
       

        [HttpGet]
        [SwaggerOperation(Summary = "This API is to Get All UserHistory")]
        public async Task<IActionResult> GetAll()
        {
            return await _userHistoryService.GetAllAsync();
        }

    }
}
