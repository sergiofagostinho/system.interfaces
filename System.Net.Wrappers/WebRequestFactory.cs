using System.Net.Interfaces;

namespace System.Net.Wrappers
{
    public class WebRequestFactory : IWebRequestFactory
    {
        #region IWebRequestFactory Members

        public IWebRequest Create(string requestUriString)
        {
            return Wrap(System.Net.WebRequest.Create(requestUriString));
        }

        public IWebRequest Create(Uri requestUriString)
        {
            return Wrap(System.Net.WebRequest.Create(requestUriString));
        }

        public IWebRequest CreateDefault(Uri requestUri)
        {
            return Wrap(System.Net.WebRequest.CreateDefault(requestUri));
        }

        public bool RegisterPrefix(string prefix, IWebRequestCreate creator)
        {
            return System.Net.WebRequest.RegisterPrefix(prefix, creator);
        }

        #endregion

        #region Private Methods

        private IWebRequest Wrap(System.Net.WebRequest webRequest)
        {
            if (webRequest is System.Net.FileWebRequest)
                return new FileWebRequest(webRequest as System.Net.FileWebRequest);
            if (webRequest is System.Net.FtpWebRequest)
                return new FtpWebRequest(webRequest as System.Net.FtpWebRequest);
            if (webRequest is System.Net.HttpWebRequest)
                return new HttpWebRequest(webRequest as System.Net.HttpWebRequest);

            throw new NotSupportedException("Unsupported web request type: " + webRequest.GetType());
        }

        #endregion
    }
}
