using App.Common.DTOs;
using App.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialMeasureController : ControllerBase
    {
        private readonly ISpecialMeasureService _specialMeasure;

        public SpecialMeasureController(ISpecialMeasureService specialMeasure)
        {
            _specialMeasure = specialMeasure;
        }

        [HttpGet]
        [Route("GetAllMessages")]
        public List<SpecialMeasureContract> GetAllMessages()
        {
            return _specialMeasure.GetAllMessages();
        }

        [HttpPost]
        [Route("CreateMessage")]
        public async Task<IActionResult> CreateMessage(SpecialMeasureContract message)
        {
            await _specialMeasure.CreateMessage(message);
            return Ok(message);
        }
    }
}
