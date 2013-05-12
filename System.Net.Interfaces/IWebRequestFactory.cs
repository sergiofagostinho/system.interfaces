using System;

namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface which replaces the WebRequest factory methods.
    /// </summary>
    public interface IWebRequestFactory
    {
        IWebRequest Create(string requestUri);
        IWebRequest Create(Uri requestUri);
        IWebRequest CreateDefault(Uri requestUri);
        bool RegisterPrefix(string prefix, IWebRequestCreate creator);
    }
}
