using AirplaneFactory.Application.Interfaces;
using AirplaneFactory.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AirplaneFactory.Api.Controllers.V1
{
    [Route("api/v1/airplanes")]
    [ApiController]
    public class AirplanesController : BaseController
    {
        private readonly IAirplaneAppService _airplaneAppService;
        public AirplanesController(IAirplaneAppService airplaneAppService)
        {
            _airplaneAppService = airplaneAppService;
        }

        [HttpGet]
        public IActionResult All()
        {
            var result = _airplaneAppService.All();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Read(int id)
        {
            var result = _airplaneAppService.Read(id);
            return ProcessResponseResult(result);
        }

        [HttpPost]
        public IActionResult Add([FromBody] AirplaneViewModel model)
        {
            var result = _airplaneAppService.Add(model);
            return ProcessResponseResult(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _airplaneAppService.Delete(id);
            return ProcessResponseResult(result);
        }

        [HttpPatch("{id}/run/{motorId}")]
        public IActionResult RunMotors(int id, int motorId)
        {
            var result = _airplaneAppService.RunMotors(id, motorId);
            return ProcessResponseResult(result);
        }

        [HttpPatch("{id}/stop/{motorId}")]
        public IActionResult StopMotors(int id, int motorId)
        {
            var result = _airplaneAppService.StopMotors(id, motorId);
            return ProcessResponseResult(result);
        }
    }
}
