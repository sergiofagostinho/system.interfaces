using System.Net.Interfaces;

namespace System.Net.Wrappers
{
    public class FileWebRequest : WebRequest, IFileWebRequest
    {
        private System.Net.FileWebRequest _webRequest;

        internal FileWebRequest(System.Net.FileWebRequest webRequest)
            : base (webRequest)
        {
            if (webRequest == null)
                throw new ArgumentNullException("webRequest");

            _webRequest = webRequest;
        }
    }
}
