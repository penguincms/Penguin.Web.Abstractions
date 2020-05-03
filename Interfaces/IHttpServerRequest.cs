using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IHttpServerRequest : IHttpInteractionBase
    {
        string Method { get; }
        string Url { get; }
    }
}
