using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Principal;

namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface to abstract the System.Net.WebRequest class for Unit Testing purposes.
    /// </summary>
    public interface IWebRequest
    {
        #region Properties

        AuthenticationLevel AuthenticationLevel { get; set; }
        RequestCachePolicy CachePolicy { get; set; }
        string ConnectionGroupName { get; set; }
        long ContentLength { get; set; }
        string ContentType { get; set; }
        ICredentials Credentials { get; set; }
        WebHeaderCollection Headers { get; set; }
        TokenImpersonationLevel ImpersonationLevel { get; set; }
        string Method { get; set; }
        bool PreAuthenticate { get; set; }
        IWebProxy Proxy { get; set; }
        Uri RequestUri { get; }
        int Timeout { get; set; }
        bool UseDefaultCredentials { get; set; }

        #endregion

        #region Methods

        void Abort();
        Stream GetRequestStream();
        IWebResponse GetResponse();

        #endregion

    }
}
