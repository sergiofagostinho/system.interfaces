
namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface to abstract the System.Net.HttpWebResponse class for Unit Testing purposes.
    /// </summary>
    public interface IHttpWebResponse : IWebResponse
    {
        #region Properties

        string CharacterSet { get; }
        string ContentEncoding { get; }
        CookieCollection Cookies { get; set; }
        DateTime LastModified { get; }
        string Method { get; }
        Version ProtocolVersion { get; }
        string Server { get; }
        HttpStatusCode StatusCode { get; }
        string StatusDescription { get; }

        #endregion

        #region Methods

        string GetResponseHeader(string headerName);

        #endregion
    }
}
