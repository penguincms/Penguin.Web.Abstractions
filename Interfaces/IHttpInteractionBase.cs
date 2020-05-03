using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IHttpInteractionBase
    {
        string ContentType { get; }
        string BodyText { get; }
        IDictionary<string, string> Headers { get; }
    }
}
