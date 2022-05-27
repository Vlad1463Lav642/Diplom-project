namespace BaikalProject.BL.Other
{
    /// <summary>
    /// Класс для хранения координат.
    /// </summary>
    public class MapPoint
    {
        #region Параметры
        public double x { get; set; }
        public double y { get; set; }
        #endregion

        /// <summary>
        /// Установить координату X и координату Y.
        /// </summary>
        /// <param name="X">Координата X.</param>
        /// <param name="Y">Координата Y.</param>
        public MapPoint(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string ReturnString()
        {
            return x + " : " + y;
        }
    }
}