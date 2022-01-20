using BaikalProject.BL.Other;
using System.Collections.Generic;

namespace BaikalProject.BL.Controller
{
    public interface IMathematicModel
    {
        /// <summary>
        /// Get pollution into points polygon.
        /// </summary>
        /// <param name="selectedProbPoints">List with selected probPoints.</param>
        /// <returns>Matrix with pollutions into points.</returns>
        double[,] MathematicPoint(List<string> selectedProbPoints);

        /// <summary>
        /// Set oils and elements into all probPoints.
        /// </summary>
        /// <param name="elements">Dictionary with oils and elements.</param>
        void SetOilsAndElements(Dictionary<string, double> elements);

        /// <summary>
        /// Set distance from checked point to probPoint.
        /// </summary>
        /// <param name="distance">Dictionary with distance.</param>
        void SetDistance(Dictionary<string, double[,]> genericDistanceDictionary);

        /// <summary>
        /// Get matrix with all points from polygon. 
        /// </summary>
        /// <returns>Matrix with all points.</returns>
        MapPoint[,] GetMatrixPoints();

        /// <summary>
        /// Get pollution into season.
        /// </summary>
        /// <param name="points">Matrix with pollution into points.</param>
        /// <returns>Pollution into season.</returns>
        double MathematicSeason(double[,] points);

        /// <summary>
        /// Get pollution into year.
        /// </summary>
        /// <param name="points">Pollution into season.</param>
        /// <param name="T">Number of days.</param>
        /// <returns>Pollution into year.</returns>
        double MathematicYear(double points, int T);

        /// <summary>
        /// Get X Coordinate of pollution polygon.
        /// </summary>
        /// <returns></returns>
        int GetMaxX();

        /// <summary>
        /// Get Y Coordinate of pollution polygon.
        /// </summary>
        /// <returns></returns>
        int GetMaxY();

        /// <summary>
        /// Get pollution into current selected point.
        /// </summary>
        /// <param name="x">Coordinate X</param>
        /// <param name="y">Coordinate Y</param>
        /// <param name="selectedProbPoints">List with selected probPoints.</param>
        /// <returns>Pollution into curent selected point.</returns>
        double MathematicPoint(double x, double y, List<string> selectedProbPoints);

        /// <summary>
        /// Get distance beetween two points.
        /// </summary>
        /// <param name="lon1">Longtitude point 1.</param>
        /// <param name="lat1">Latitude point 1.</param>
        /// <param name="lon2">Longtitude point 2.</param>
        /// <param name="lat2">Latitude point 2.</param>
        /// <returns>Distance between two points.</returns>
        double DistanceBetweenPlaces(double lon1, double lat1, double lon2, double lat2);
    }
}