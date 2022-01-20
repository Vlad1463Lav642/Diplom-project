using System;
using System.Collections.Generic;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Other;

namespace BaikalProject.BL.Model
{
    /// <summary>
    /// Work with mathematic model.
    /// </summary>
    public class MathematicModel : IMathematicModel
    {
        #region Parametrs
        private IDatabase database;
        private Dictionary<string, double> oilsAndElements;
        private int X = 120;
        private int Y = 270;
        private const double step = 0.05;
        private MapPoint startPoint;
        private MapPoint[,] genericPoints;
        private Dictionary<string, double[,]> distanceToPoint;
        #endregion

        /// <summary>
        /// Set all coordinates of probPositions.
        /// </summary>
        /// <param name="coordinates">Dictionary with probPositions.</param>
        public MathematicModel()
        {
            database = new Database.Database();
            oilsAndElements = new Dictionary<string, double>();
            distanceToPoint = new Dictionary<string, double[,]>();
            startPoint = new MapPoint(50.6412857695467, 100.128129882813);

            double xStart = startPoint.x;
            double yStart = startPoint.y;
            int xTimer = 0;
            int yTimer = 0;

            genericPoints = new MapPoint[X, Y];

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (yTimer < Y)
                    {
                        genericPoints[i, j] = new MapPoint(xStart, yStart);
                        yStart += step;
                        yTimer++;
                    }
                }
                if (xTimer < X)
                {
                    xStart += step;
                    xTimer++;
                    yTimer = 0;
                }
                yStart = startPoint.y;
            }
        }

        /// <summary>
        /// Get matrix with all points from polygon. 
        /// </summary>
        /// <returns>Matrix with all points.</returns>
        public MapPoint[,] GetMatrixPoints()
        {
            return genericPoints;
        }

        /// <summary>
        /// Set oils and elements into all probPoints.
        /// </summary>
        /// <param name="elements">Dictionary with oils and elements.</param>
        public void SetOilsAndElements(Dictionary<string, double> elements)
        {
            oilsAndElements = elements;
        }

        /// <summary>
        /// Set distance from checked point to probPoint.
        /// </summary>
        /// <param name="distance">Dictionary with distance.</param>
        public void SetDistance(Dictionary<string, double[,]> genericDistanceDictionary)
        {
            distanceToPoint = genericDistanceDictionary;
        }

        /// <summary>
        /// Get X Coordinate of pollution polygon.
        /// </summary>
        /// <returns></returns>
        public int GetMaxX()
        {
            return X;
        }

        /// <summary>
        /// Get Y Coordinate of pollution polygon.
        /// </summary>
        /// <returns></returns>
        public int GetMaxY()
        {
            return Y;
        }

        /// <summary>
        /// Get pollution into points polygon.
        /// </summary>
        /// <param name="selectedProbPoints">List with selected probPoints.</param>
        /// <returns>Matrix with pollutions into points.</returns>
        public double[,] MathematicPoint(List<string> selectedProbPoints)
        {
            double resultFirst = 0;
            double resultSecond = 0;
            double[,] result = new double[X, Y];


            for (int j = 0; j < X; j++)
            {
                for (int k = 0; k < Y; k++)
                {
                    for (int i = 0; i < selectedProbPoints.Count; i++)
                    {
                        resultFirst += oilsAndElements[selectedProbPoints[i]] / Math.Pow(distanceToPoint[selectedProbPoints[i]][j, k],2);
                        resultSecond += 1 / Math.Pow(distanceToPoint[selectedProbPoints[i]][j, k],2);
                    }
                    result[j, k] = resultFirst / resultSecond;
                    resultFirst = 0;
                    resultSecond = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// Get pollution into current selected point.
        /// </summary>
        /// <param name="x">Coordinate X</param>
        /// <param name="y">Coordinate Y</param>
        /// <param name="selectedProbPoints">List with selected probPoints.</param>
        /// <returns>Pollution into curent selected point.</returns>
        public double MathematicPoint(double x,double y, List<string> selectedProbPoints)
        {
            double resultFirst = 0;
            double resultSecond = 0;
            Dictionary<string, MapPoint> points = database.GetCoordinates();

            for (int i = 0; i < selectedProbPoints.Count; i++)
            {
                double kmLength = DistanceBetweenPlaces(y, x, points[selectedProbPoints[i]].y, points[selectedProbPoints[i]].x);
                resultFirst += oilsAndElements[selectedProbPoints[i]] / Math.Pow(kmLength, 2);
                resultSecond += 1 / Math.Pow(kmLength, 2);
            }

            return resultFirst / resultSecond;
        }

        /// <summary>
        /// Get pollution into season.
        /// </summary>
        /// <param name="points">Matrix with pollution into points.</param>
        /// <returns>Pollution into season.</returns>
        public double MathematicSeason(double[,] points)
        {
            double result = 0;

            double kmStep = DistanceBetweenPlaces(genericPoints[0, 0].y, genericPoints[0, 0].x, genericPoints[0, 1].y, genericPoints[0, 1].x);

            for (int i = 0; i < X; i++)
            {
                for(int j = 0; j < Y; j++)
                {
                    result += points[i,j] * Math.Pow(kmStep, 2);
                }
            }

            return result;
        }

        /// <summary>
        /// Get pollution into year.
        /// </summary>
        /// <param name="points">Pollution into season.</param>
        /// <param name="T">Number of days.</param>
        /// <returns>Pollution into year.</returns>
        public double MathematicYear(double points,int T)
        {
            double result = 0;

            for(int i = 0; i < X; i++)
            {
                for(int j = 0; j < Y; j++)
                {
                    result = (points * 365) / T;
                }
            }

            return result;
        }

        /// <summary>
        /// Get radians.
        /// </summary>
        /// <param name="x">Coordinate.</param>
        /// <returns>Radians.</returns>
        private double Radians(double x)
        {
            return x * Math.PI / 180;
        }

        /// <summary>
        /// Get distance beetween two points.
        /// </summary>
        /// <param name="lon1">Longtitude point 1.</param>
        /// <param name="lat1">Latitude point 1.</param>
        /// <param name="lon2">Longtitude point 2.</param>
        /// <param name="lat2">Latitude point 2.</param>
        /// <returns>Distance between two points.</returns>
        public double DistanceBetweenPlaces(double lon1, double lat1, double lon2, double lat2)
        {
            double R = 6371; // Earth’s radius in km

            double sLat1 = Math.Sin(Radians(lat1));
            double sLat2 = Math.Sin(Radians(lat2));
            double cLat1 = Math.Cos(Radians(lat1));
            double cLat2 = Math.Cos(Radians(lat2));
            double cLon = Math.Cos(Radians(lon1) - Radians(lon2));

            double cosD = sLat1 * sLat2 + cLat1 * cLat2 * cLon;

            double d = Math.Acos(cosD);

            double dist = R * d;

            return dist;
        }
    }
}