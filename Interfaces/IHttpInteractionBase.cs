using System.Collections.Generic;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IHttpInteractionBase
    {
        string BodyText { get; }

        string ContentType { get; }

        IDictionary<string, string> Headers { get; }
    }
}