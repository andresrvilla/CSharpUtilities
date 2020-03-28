using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpUtilities.Net.Rest.DTOClasses
{
    public class RestErrorResponseDTO: RestResponseDTO
    {
        public string message { get; set; }

        public RestErrorResponseDTO(bool ok, int statusCode,string message): base(ok,statusCode)
        {
            this.message = message;
        }
    }
}
