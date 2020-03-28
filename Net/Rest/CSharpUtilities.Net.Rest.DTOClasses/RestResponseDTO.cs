using System;

namespace CSharpUtilities.Net.Rest.DTOClasses
{
    public class RestResponseDTO
    {
        public bool ok { get; set; }

        public int statusCode { get; set; }

        public RestResponseDTO(bool ok, int statusCode)
        {
            this.ok = ok;
            this.statusCode = statusCode;
        }
    }
}
