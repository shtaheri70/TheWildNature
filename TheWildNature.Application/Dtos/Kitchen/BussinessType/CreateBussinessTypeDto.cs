using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWildNature.Application.Dtos.Kitchen.BussinesType
{
    public class CreateBussinessTypeDto:IBussinessTypeDto
    {
        public string BusinessTypeTitle { get; set; }
    }
}
