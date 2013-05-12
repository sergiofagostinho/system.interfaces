using System.IO;

namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface to abstract the System.Net.WebResponse class for Unit Testing purposes.
    /// </summary>
    public interface IWebResponse
    {
        #region Properties

        long ContentLength { get; set; }
        string ContentType { get; set; }
        WebHeaderCollection Headers { get; }
        bool IsFromCache { get; }
        bool IsMutuallyAuthenticated { get; }
        Uri ResponseUri { get; }

        #endregion

        #region Methods

        void Close();
        Stream GetResponseStream();

        #endregion
    }
}
