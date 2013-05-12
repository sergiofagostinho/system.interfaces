using System.Net.Interfaces;

namespace System.Net.Wrappers
{
    public class HttpWebResponse : WebResponse, IHttpWebResponse
    {
        private System.Net.HttpWebResponse _webResponse;

        internal HttpWebResponse(System.Net.HttpWebResponse webResponse)
            : base(webResponse)
        {
            if (webResponse == null)
                throw new ArgumentNullException("webResponse");

            _webResponse = webResponse;
        }

        #region IHttpWebResponse Members

        public string CharacterSet
        {
            get { return _webResponse.CharacterSet; }
        }

        public string ContentEncoding
        {
            get { return _webResponse.ContentEncoding; }
        }

        public CookieCollection Cookies
        {
            get
            {
                return _webResponse.Cookies;
            }
            set
            {
                _webResponse.Cookies = value;
            }
        }

        public DateTime LastModified
        {
            get { return _webResponse.LastModified; }
        }

        public string Method
        {
            get { return _webResponse.Method; }
        }

        public Version ProtocolVersion
        {
            get { return _webResponse.ProtocolVersion; }
        }

        public string Server
        {
            get { return _webResponse.Server; }
        }

        public HttpStatusCode StatusCode
        {
            get { return _webResponse.StatusCode; }
        }

        public string StatusDescription
        {
            get { return _webResponse.StatusDescription; }
        }

        public string GetResponseHeader(string headerName)
        {
            return _webResponse.GetResponseHeader(headerName);
        }

        #endregion
    }
}
