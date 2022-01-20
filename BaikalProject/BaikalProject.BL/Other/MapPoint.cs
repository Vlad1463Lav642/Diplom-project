namespace BaikalProject.BL.Other
{
    /// <summary>
    /// Class for storage coordinates.
    /// </summary>
    public class MapPoint
    {
        #region Parametrs
        public double x { get; set; }
        public double y { get; set; }
        #endregion

        /// <summary>
        /// Set coordinate X and coordinate Y.
        /// </summary>
        /// <param name="X">coordinate X.</param>
        /// <param name="Y">coordinate Y.</param>
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