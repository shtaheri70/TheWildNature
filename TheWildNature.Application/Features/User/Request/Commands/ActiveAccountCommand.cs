using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWildNature.Application.Features.User.Request.Commands
{
    public class ActiveAccountCommand:IRequest<bool>
    {
        public  string ActiveCode { get; set; }
    }
}
