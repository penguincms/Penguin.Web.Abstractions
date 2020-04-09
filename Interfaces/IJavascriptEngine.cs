using System;

namespace Penguin.Web.Abstractions
{
    public interface IJavascriptEngine : IDisposable
    {
        string Execute(string toExecute);
    }
}