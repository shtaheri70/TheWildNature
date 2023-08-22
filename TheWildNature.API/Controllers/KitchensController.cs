using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;
using TheWildNature.Application.Dtos.Kitchen.FinancialInfo;
using TheWildNature.Application.Dtos.Kitchen.KitchenLicense;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands;
using TheWildNature.Application.Features.Kitchen.BusinessType.Request.Queries;
using TheWildNature.Application.Features.Kitchen.FinancialInfo.Request.Commands;
using TheWildNature.Application.Features.Kitchen.KitchenLicence.Request.Commands;
using TheWildNature.Application.Features.Kitchen.Request.Commands;
using TheWildNature.Application.Features.Kitchen.Request.Queries;
using TheWildNature.Application.Response;
using TheWildNature.Domain.Entities.Kitchen;

namespace TheWildNature.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitchensController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IFilesServise _fileServise;
        public KitchensController(IMediator mediator, IFilesServise fileServis)
        {
            this._mediator = mediator;
            _fileServise = fileServis;
        }
        // GET api/<KitchensController>/GetBussinessTypeList
        [HttpGet("GetBussinessTypeList")]
        public async Task<ActionResult<List<BussinessTypeDto>>> GetBussinessTypeList()
        {
            var bussinessTypeList = await _mediator.Send(new GetBussinessTypeListRequest());
            return Ok(bussinessTypeList);
        }
        // GET api/<KitchensController>/GetBussinessType/5
        [HttpGet("GetBussinessType/{id}")]
        public async Task<ActionResult<List<BussinessTypeDto>>> GetBussinessType(int id)
        {
            var bussinessTypeList = await _mediator.Send(new GetBussinessTypeDetailsRequset { Id = id });
            return Ok(bussinessTypeList);
        }
        // POST api/<KitchensController>/PostBussinessType
        [HttpPost("PostBussinessType")]
        public async Task<ActionResult<BaseCommandResponse>> PostBussinessType([FromBody] CreateBussinessTypeDto bussinessType)
        {
            var command = new CreateBussinessTypeCommand { BussinessTypeDto = bussinessType };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // PUT api/<KitchensController>/PutBussinessType/5
        [HttpPut("PutBussinessType/{id}")]
        public async Task<ActionResult> PutBussinessType(int id, [FromBody] BussinessTypeDto bussinessType)
        {
            var command = new EditBussinessTypeCommand { BussinessTypeDto = bussinessType };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // DELETE api/<KitchensController>/DeleteBussinessType/5
        [HttpDelete("DeleteBussinessType/{id}")]
        public async Task<ActionResult> DeleteBussinessType(int id)
        {
            var command = new DeleteBussinessTypeCommand { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // POST api/<Kitchens>
        [HttpPost("RegisterBasicInfo")]
        public async Task<ActionResult<BaseCommandResponse>> RegisterBasicInfo([FromBody] CreateKitchenBaiscInfoDto kitchenBasicInfo)
        {
            var command = new CreateKitchenBasicInfoCommand { RegisterKitchenBaiscInfoDto = kitchenBasicInfo };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("GetKitchenAndManagerInfo/{UserId}")]
        public async Task<ActionResult<Kitchen>> GetKitchenAndManagerInfo(int UserId)
        {
            var command = new GetKitchenAndManagerInfoRequset { UserId = UserId };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("UpdateKitchenAndManagerInfo")]
        public async Task<ActionResult> UpdateKitchenAndManagerInfo([FromBody] UpdateKitchenAndKitchenManagerInfoDto kitchen)
        {
            var command = new UpdateKitchenAndManagerInfoCommand { KitchenDto = kitchen };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        // POST api/<KitchensController>/RgisterKitchenFinancialInfo
        [HttpPost("RgisterKitchenFinancialInfo/{kitchenId}")]
        public async Task<ActionResult> RegisterKitchenFinancialInfo(int kitchenId, [FromForm] CreateKitchenFinancialInfoDto financialInfo)
        {
            var command = new CreateKitchenFinancialInfoCommand { KitchenFinancialInfoDto = financialInfo,KitchenId=kitchenId };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // POST api/<KitchensController>/RgisterKitchenLicence
        [HttpPost("RgisterKitchenLicence/{kitchenId}")]
        public async Task<ActionResult> RgisterKitchenLicence(int kitchenId, [FromForm] CreateKitchenLicenseDto license)
        {
            var command = new CreateKitchenLicenceCommand { CreateKitchenLicenseDto = license, KitchenId = kitchenId };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // Get api/<KitchensController>/GetKitchen/4
        [HttpGet("GetKitchen/{kitchenId}")]
        public async Task<ActionResult<KitchenDto>> GetKitchen(int kitchenId)
        {
            var kitchen = await _mediator.Send(new GetKitchenRequest { KitchenId = kitchenId });
            return Ok(kitchen);
        }

        // Post api/<KitchensController>/EditKitchen
        [HttpPut("EditKitchen")]
        public async Task<ActionResult> EditKitchen([FromForm] KitchenDto kitchen)
        {
            var command = new EditKitchenCommand { KitchenDto = kitchen };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
