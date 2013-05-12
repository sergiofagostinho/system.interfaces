using System.Net.Interfaces;

namespace System.Net.Wrappers
{
    public class FtpWebResponse : WebResponse, IFtpWebResponse
    {
        private System.Net.FtpWebResponse _webResponse;

        internal FtpWebResponse(System.Net.FtpWebResponse webResponse)
            : base(webResponse)
        {
            if (webResponse == null)
                throw new ArgumentNullException("webResponse");

            _webResponse = webResponse;
        }

        #region IFtpWebResponse Members

        public string BannerMessage
        {
            get { return _webResponse.BannerMessage; }
        }

        public string ExitMessage
        {
            get { return _webResponse.ExitMessage; }
        }

        public DateTime LastModified
        {
            get { return _webResponse.LastModified; }
        }

        public FtpStatusCode StatusCode
        {
            get { return _webResponse.StatusCode; }
        }

        public string StatusDescription
        {
            get { return _webResponse.StatusDescription; }
        }

        public string WelcomeMessage
        {
            get { return _webResponse.WelcomeMessage; }
        }

        #endregion
    }
}
