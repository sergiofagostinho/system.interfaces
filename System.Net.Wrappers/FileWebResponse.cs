using System.Net.Interfaces;

namespace System.Net.Wrappers
{
    public class FileWebResponse : WebResponse, IFileWebResponse
    {
        private System.Net.FileWebResponse _webResponse;

        internal FileWebResponse(System.Net.FileWebResponse webResponse)
            : base (webResponse)
        {
            if (webResponse == null)
                throw new ArgumentNullException("webResponse");

            _webResponse = webResponse;
        }
    }
}
