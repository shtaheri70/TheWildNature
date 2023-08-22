using MediatR;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands
{
    public class DeleteBussinessTypeCommand:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
