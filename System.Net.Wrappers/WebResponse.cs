using System.IO;
using System.Net.Interfaces;

namespace System.Net.Wrappers
{
    public abstract class WebResponse : IWebResponse
    {
        private System.Net.WebResponse _webResponse;

        internal WebResponse(System.Net.WebResponse webResponse)
        {
            if (webResponse == null)
                throw new ArgumentNullException("webResponse");

            _webResponse = webResponse;
        }

        #region IWebResponse Members

        public long ContentLength
        {
            get
            {
                return _webResponse.ContentLength;
            }
            set
            {
                _webResponse.ContentLength = value;
            }
        }

        public string ContentType
        {
            get
            {
                return _webResponse.ContentType;
            }
            set
            {
                _webResponse.ContentType = value;
            }
        }

        public WebHeaderCollection Headers
        {
            get { return _webResponse.Headers; }
        }

        public bool IsFromCache
        {
            get { return _webResponse.IsFromCache; }
        }

        public bool IsMutuallyAuthenticated
        {
            get { return _webResponse.IsMutuallyAuthenticated; }
        }

        public Uri ResponseUri
        {
            get { return _webResponse.ResponseUri; }
        }

        public void Close()
        {
            _webResponse.Close();
        }

        public Stream GetResponseStream()
        {
            return _webResponse.GetResponseStream();
        }

        #endregion
    }
}
