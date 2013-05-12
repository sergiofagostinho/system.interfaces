using System.Net.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Wrappers
{
    public class FtpWebRequest : WebRequest, IFtpWebRequest
    {
        private System.Net.FtpWebRequest _webRequest;

        internal FtpWebRequest(System.Net.FtpWebRequest webRequest)
            : base(webRequest)
        {
            if (webRequest == null)
                throw new ArgumentNullException("webRequest");

            _webRequest = webRequest;
        }

        #region IFtpWebRequest Members

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

        public long ContentOffset
        {
            get
            {
                return _webRequest.ContentOffset;
            }
            set
            {
                _webRequest.ContentOffset = value;
            }
        }

        public bool EnableSsl
        {
            get
            {
                return _webRequest.EnableSsl;
            }
            set
            {
                _webRequest.EnableSsl = value;
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

        public string RenameTo
        {
            get
            {
                return _webRequest.RenameTo;
            }
            set
            {
                _webRequest.RenameTo = value;
            }
        }

        public ServicePoint ServicePoint
        {
            get { return _webRequest.ServicePoint; }
        }

        public bool UseBinary
        {
            get
            {
                return _webRequest.UseBinary;
            }
            set
            {
                _webRequest.UseBinary = value;
            }
        }

        public bool UsePassive
        {
            get
            {
                return _webRequest.UsePassive;
            }
            set
            {
                _webRequest.UsePassive = value;
            }
        }

        public override IWebResponse GetResponse()
        {
            return new FtpWebResponse(_webRequest.GetResponse() as System.Net.FtpWebResponse);
        }

        #endregion

    }
}
