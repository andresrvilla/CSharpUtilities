using System;

namespace CSharpUtilities.Net.Rest.DTOClasses
{
    public class RestResponseDTO
    {
        public bool ok { get; set; }

        public int statusCode { get; set; }

        protected const int STATUSCODE_OK = 200;

        protected const bool OK = true;

        protected const bool FAILURE = false;

        public RestResponseDTO(bool ok, int statusCode)
        {
            this.ok = ok;
            this.statusCode = statusCode;
        }
    }
}
