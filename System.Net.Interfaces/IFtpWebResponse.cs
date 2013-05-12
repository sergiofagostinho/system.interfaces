
namespace System.Net.Interfaces
{
    /// <summary>
    /// Interface to abstract the System.Net.FtpWebResponse class for Unit Testing purposes.
    /// </summary>
    public interface IFtpWebResponse : IWebResponse
    {
        #region Properties

        string BannerMessage { get; }
        string ExitMessage { get; }
        DateTime LastModified { get; }
        FtpStatusCode StatusCode { get; }
        string StatusDescription { get; }
        string WelcomeMessage { get; }

        #endregion

        #region Methods


        #endregion
    }
}