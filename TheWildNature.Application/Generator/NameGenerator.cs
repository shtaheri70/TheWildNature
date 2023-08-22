using System;
using System.Collections.Generic;
using System.Text;

namespace TheWildNature.Application.Generator
{
    public class NameGenerator
    {
        public static string GenerateUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
