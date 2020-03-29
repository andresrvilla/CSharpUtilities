using System;

namespace CSharpUtilities.Entities.Interfaces
{
    public interface IAuditData
    {
        string Creator { get; set; }

        DateTime CreationDate { get; set; }

        string Modifier { get; set; }

        DateTime ModificationDate { get; set; }

        long AccessCount { get; set; }
    }
}
