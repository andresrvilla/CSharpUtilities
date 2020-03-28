using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpUtilities.Net.Rest.DTOClasses
{
    public class RestResponseObjectDTO: RestResponseDTO
    {
        public object result { get; set; }
    }
}
