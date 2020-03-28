using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpUtilities.Net.Rest.DTOClasses
{
    public class RestErrorResponseDTO : RestResponseDTO
    {
        public string message { get; set; } = string.Empty;

        public RestErrorResponseDTO(int statusCode) : base(FAILURE, statusCode)
        {

        }

        public RestErrorResponseDTO(int statusCode, string message) : base(FAILURE, statusCode)
        {
            this.message = message;
        }

    }
}
