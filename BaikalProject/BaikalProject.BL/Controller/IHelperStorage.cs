namespace BaikalProject.BL.Controller
{
    /// <summary>
    /// Contains all needed information for working with interface.
    /// </summary>
    public interface IHelperStorage
    {
        /// <summary>
        /// Get string information from data storage.
        /// </summary>
        /// <param name="key">Key string.</param>
        /// <returns>Data information.</returns>
        string GetDataString(string key);
    }
}