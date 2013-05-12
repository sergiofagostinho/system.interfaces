using System.Security.Cryptography.X509Certificates;

namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface to abstract the System.Net.HttpWebRequest class for Unit Testing purposes.
    /// </summary>
    public interface IHttpWebRequest : IWebRequest
    {
        #region Properties

        string Accept { get; set; }
        Uri Address { get; }
        bool AllowAutoRedirect { get; set; }
        bool AllowWriteStreamBuffering { get; set; }
        DecompressionMethods AutomaticDecompression { get; set; }
        X509CertificateCollection ClientCertificates { get; set; }
        string Connection { get; set; }
        HttpContinueDelegate ContinueDelegate { get; set; }
        CookieContainer CookieContainer { get; set; }
        DateTime Date { get; set; }
        string Expect { get; set; }
        bool HaveResponse { get; }
        string Host { get; set; }
        DateTime IfModifiedSince { get; set; }
        bool KeepAlive { get; set; }
        int MaximumAutomaticRedirections { get; set; }
        int MaximumResponseHeadersLength { get; set; }
        string MediaType { get; set; }
        bool Pipelined { get; set; }
        Version ProtocolVersion { get; set; }
        int ReadWriteTimeout { get; set; }
        string Referer { get; set; }
        bool SendChunked { get; set; }
        ServicePoint ServicePoint { get; }
        string TransferEncoding { get; set; }
        bool UnsafeAuthenticatedConnectionSharing { get; set; }
        string UserAgent { get; set; }

        #endregion

        #region Methods

        void AddRange(int range);
        void AddRange(long range);
        void AddRange(int from, int to);
        void AddRange(long from, long to);
        void AddRange(string rangeSpecifier, int range);
        void AddRange(string rangeSpecifier, long range);
        void AddRange(string rangeSpecifier, int from, int to);
        void AddRange(string rangeSpecifier, long from, long to);

        #endregion
    }
}
