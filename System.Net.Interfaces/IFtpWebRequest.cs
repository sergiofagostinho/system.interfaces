using System.Security.Cryptography.X509Certificates;

namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface to abstract the System.Net.FtpWebResponse class for Unit Testing purposes.
    /// </summary>
    public interface IFtpWebRequest : IWebRequest
    {
        #region Properties

        X509CertificateCollection ClientCertificates { get; set; }
        long ContentOffset { get; set; }
        bool EnableSsl { get; set; }
        bool KeepAlive { get; set; }
        int ReadWriteTimeout { get; set; }
        string RenameTo { get; set; }
        ServicePoint ServicePoint { get; }
        bool UseBinary { get; set; }
        bool UsePassive { get; set; }

        #endregion

        #region Methods

        #endregion
    }
}
