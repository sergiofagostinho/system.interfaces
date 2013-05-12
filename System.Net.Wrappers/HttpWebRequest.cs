using System.IO;
using System.Net.Interfaces;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace System.Net.Wrappers
{
    public class HttpWebRequest : WebRequest, IHttpWebRequest
    {
        private System.Net.HttpWebRequest _webRequest;

        internal HttpWebRequest(System.Net.HttpWebRequest webRequest)
            : base(webRequest)
        {
            if (webRequest == null)
                throw new ArgumentNullException("webRequest");

            _webRequest = webRequest;
        }

        #region IHttpWebRequest Members

        public string Accept
        {
            get
            {
                return _webRequest.Accept;
            }
            set
            {
                _webRequest.Accept = value;
            }
        }

        public Uri Address
        {
            get { return _webRequest.Address; }
        }

        public bool AllowAutoRedirect
        {
            get
            {
                return _webRequest.AllowAutoRedirect;
            }
            set
            {
                _webRequest.AllowAutoRedirect = value;
            }
        }

        public bool AllowWriteStreamBuffering
        {
            get
            {
                return _webRequest.AllowWriteStreamBuffering;
            }
            set
            {
                _webRequest.AllowWriteStreamBuffering = value;
            }
        }

        public DecompressionMethods AutomaticDecompression
        {
            get
            {
                return _webRequest.AutomaticDecompression;
            }
            set
            {
                _webRequest.AutomaticDecompression = value;
            }
        }

        public X509CertificateCollection ClientCertificates
        {
            get
            {
                return _webRequest.ClientCertificates;
            }
            set
            {
                _webRequest.ClientCertificates = value;
            }
        }

        public string Connection
        {
            get
            {
                return _webRequest.Connection;
            }
            set
            {
                _webRequest.Connection = value;
            }
        }

        public HttpContinueDelegate ContinueDelegate
        {
            get
            {
                return _webRequest.ContinueDelegate;
            }
            set
            {
                _webRequest.ContinueDelegate = value;
            }
        }

        public CookieContainer CookieContainer
        {
            get
            {
                return _webRequest.CookieContainer;
            }
            set
            {
                _webRequest.CookieContainer = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _webRequest.Date;
            }
            set
            {
                _webRequest.Date = value;
            }
        }

        public string Expect
        {
            get
            {
                return _webRequest.Expect;
            }
            set
            {
                _webRequest.Expect = value;
            }
        }

        public bool HaveResponse
        {
            get { return _webRequest.HaveResponse; }
        }

        public string Host
        {
            get
            {
                return _webRequest.Host;
            }
            set
            {
                _webRequest.Host = value;
            }
        }

        public DateTime IfModifiedSince
        {
            get
            {
                return _webRequest.IfModifiedSince;
            }
            set
            {
                _webRequest.IfModifiedSince = value;
            }
        }

        public bool KeepAlive
        {
            get
            {
                return _webRequest.KeepAlive;
            }
            set
            {
                _webRequest.KeepAlive = value;
            }
        }

        public int MaximumAutomaticRedirections
        {
            get
            {
                return _webRequest.MaximumAutomaticRedirections;
            }
            set
            {
                _webRequest.MaximumAutomaticRedirections = value;
            }
        }

        public int MaximumResponseHeadersLength
        {
            get
            {
                return _webRequest.MaximumResponseHeadersLength;
            }
            set
            {
                _webRequest.MaximumResponseHeadersLength = value;
            }
        }

        public string MediaType
        {
            get
            {
                return _webRequest.MediaType;
            }
            set
            {
                _webRequest.MediaType = value;
            }
        }

        public bool Pipelined
        {
            get
            {
                return _webRequest.Pipelined;
            }
            set
            {
                _webRequest.Pipelined = value;
            }
        }

        public Version ProtocolVersion
        {
            get
            {
                return _webRequest.ProtocolVersion;
            }
            set
            {
                _webRequest.ProtocolVersion = value;
            }
        }

        public int ReadWriteTimeout
        {
            get
            {
                return _webRequest.ReadWriteTimeout;
            }
            set
            {
                _webRequest.ReadWriteTimeout = value;
            }
        }

        public string Referer
        {
            get
            {
                return _webRequest.Referer;
            }
            set
            {
                _webRequest.Referer = value;
            }
        }

        public bool SendChunked
        {
            get
            {
                return _webRequest.SendChunked;
            }
            set
            {
                _webRequest.SendChunked = value;
            }
        }

        public ServicePoint ServicePoint
        {
            get { return _webRequest.ServicePoint; }
        }

        public string TransferEncoding
        {
            get
            {
                return _webRequest.TransferEncoding;
            }
            set
            {
                _webRequest.TransferEncoding = value;
            }
        }

        public bool UnsafeAuthenticatedConnectionSharing
        {
            get
            {
                return _webRequest.UnsafeAuthenticatedConnectionSharing;
            }
            set
            {
                _webRequest.UnsafeAuthenticatedConnectionSharing = value;
            }
        }

        public string UserAgent
        {
            get
            {
                return _webRequest.UserAgent;
            }
            set
            {
                _webRequest.UserAgent = value;
            }
        }

        public void AddRange(int range)
        {
            _webRequest.AddRange(range);
        }

        public void AddRange(long range)
        {
            _webRequest.AddRange(range);
        }

        public void AddRange(int from, int to)
        {
            _webRequest.AddRange(from, to);
        }

        public void AddRange(long from, long to)
        {
            _webRequest.AddRange(from, to);
        }

        public void AddRange(string rangeSpecifier, int range)
        {
            _webRequest.AddRange(rangeSpecifier, range);
        }

        public void AddRange(string rangeSpecifier, long range)
        {
            _webRequest.AddRange(rangeSpecifier, range);
        }

        public void AddRange(string rangeSpecifier, int from, int to)
        {
            _webRequest.AddRange(rangeSpecifier, from, to);
        }

        public void AddRange(string rangeSpecifier, long from, long to)
        {
            _webRequest.AddRange(rangeSpecifier, from, to);
        }

        public override IWebResponse GetResponse()
        {
            return new HttpWebResponse(_webRequest.GetResponse() as System.Net.HttpWebResponse);
        }

        #endregion
    }
}
