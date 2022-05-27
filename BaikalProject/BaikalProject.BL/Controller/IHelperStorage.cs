namespace BaikalProject.BL.Controller
{
    /// <summary>
    /// Содержит всю необходимую информацию для работы с приложением.
    /// </summary>
    public interface IHelperStorage
    {
        /// <summary>
        /// Получить информацию из хранилища данных.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <returns>Данные.</returns>
        string GetDataString(string key);
    }
}