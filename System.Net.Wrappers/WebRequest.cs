using System.IO;
using System.Net.Cache;
using System.Net.Interfaces;
using System.Net.Security;
using System.Security.Principal;

namespace System.Net.Wrappers
{
    public abstract class WebRequest : IWebRequest
    {
        private System.Net.WebRequest _webRequest;

        internal WebRequest(System.Net.WebRequest webRequest)
        {
            if (webRequest == null)
                throw new ArgumentNullException("webRequest");

            _webRequest = webRequest;
        }

        #region IWebRequest Members

        public virtual AuthenticationLevel AuthenticationLevel
        {
            get { return _webRequest.AuthenticationLevel; }
            set { _webRequest.AuthenticationLevel = value; }
        }

        public virtual RequestCachePolicy CachePolicy
        {
            get
            {
                return _webRequest.CachePolicy;
            }
            set
            {
                _webRequest.CachePolicy = value;
            }
        }

        public virtual string ConnectionGroupName
        {
            get
            {
                return _webRequest.ConnectionGroupName;
            }
            set
            {
                _webRequest.ConnectionGroupName = value;
            }
        }

        public virtual long ContentLength
        {
            get
            {
                return _webRequest.ContentLength;
            }
            set
            {
                _webRequest.ContentLength = value;
            }
        }

        public virtual string ContentType
        {
            get
            {
                return _webRequest.ContentType;
            }
            set
            {
                _webRequest.ContentType = value;
            }
        }

        public virtual ICredentials Credentials
        {
            get
            {
                return _webRequest.Credentials;
            }
            set
            {
                _webRequest.Credentials = value;
            }
        }

        public virtual WebHeaderCollection Headers
        {
            get
            {
                return _webRequest.Headers;
            }
            set
            {
                _webRequest.Headers = value;
            }
        }

        public TokenImpersonationLevel ImpersonationLevel
        {
            get
            {
                return _webRequest.ImpersonationLevel;
            }
            set
            {
                _webRequest.ImpersonationLevel = value;
            }
        }

        public virtual string Method
        {
            get
            {
                return _webRequest.Method;
            }
            set
            {
                _webRequest.Method = value;
            }
        }

        public virtual bool PreAuthenticate
        {
            get
            {
                return _webRequest.PreAuthenticate;
            }
            set
            {
                _webRequest.PreAuthenticate = value;
            }
        }

        public virtual IWebProxy Proxy
        {
            get
            {
                return _webRequest.Proxy;
            }
            set
            {
                _webRequest.Proxy = value;
            }
        }

        public virtual Uri RequestUri
        {
            get { return _webRequest.RequestUri; }
        }

        public virtual int Timeout
        {
            get
            {
                return _webRequest.Timeout;
            }
            set
            {
                _webRequest.Timeout = value;
            }
        }

        public virtual bool UseDefaultCredentials
        {
            get
            {
                return _webRequest.UseDefaultCredentials;
            }
            set
            {
                _webRequest.UseDefaultCredentials = value;
            }
        }

        public virtual void Abort()
        {
            _webRequest.Abort();
        }

        public virtual Stream GetRequestStream()
        {
            return _webRequest.GetRequestStream();
        }

        public virtual IWebResponse GetResponse()
        {
            // this is intended behaviour: this method should only be called on descendant classes
            throw new NotImplementedException();
        }

        #endregion
    }
}
