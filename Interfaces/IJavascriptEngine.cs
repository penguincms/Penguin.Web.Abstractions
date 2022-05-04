using System;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IJavascriptEngine : IDisposable
    {
        string Execute(string toExecute);
    }
}