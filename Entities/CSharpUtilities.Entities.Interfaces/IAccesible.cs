using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpUtilities.Entities.Interfaces
{
    public interface IAccesible
    {
        long AccessCount { get; set; }
    }
}
