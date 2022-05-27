using System;
using System.Collections.Generic;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Other;

namespace BaikalProject.BL.Model
{
    /// <summary>
    /// Работа с математической моделью.
    /// </summary>
    public class MathematicModel : IMathematicModel
    {
        #region Параметры
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
        /// Инициализировать работу с математической моделью.
        /// </summary>
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
        /// Получить матрицу со всеми точками поля.
        /// </summary>
        /// <returns>Матрица с точками.</returns>
        public MapPoint[,] GetMatrixPoints()
        {
            return genericPoints;
        }

        /// <summary>
        /// Задать элементы в точках проботбора.
        /// </summary>
        /// <param name="elements">Словарь с элементы.</param>
        public void SetOilsAndElements(Dictionary<string, double> elements)
        {
            oilsAndElements = elements;
        }

        /// <summary>
        /// Задать дистанцию от выбранной точки поля до точки проботбора.
        /// </summary>
        /// <param name="distance">Словарь с дистанциями.</param>
        public void SetDistance(Dictionary<string, double[,]> genericDistanceDictionary)
        {
            distanceToPoint = genericDistanceDictionary;
        }

        /// <summary>
        /// Получить X координату поля загрязнений.
        /// </summary>
        /// <returns>X координата.</returns>
        public int GetMaxX()
        {
            return X;
        }

        /// <summary>
        /// Получить Y координату поля загрязнений.
        /// </summary>
        /// <returns>Y координата.</returns>
        public int GetMaxY()
        {
            return Y;
        }

        /// <summary>
        /// Получить матрицу загрязнений.
        /// </summary>
        /// <param name="selectedProbPoints">Список с выбранными точками проботбора.</param>
        /// <returns>Матрица с загрязнениями.</returns>
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
        /// Получить загрязнение в выбранной точке.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <param name="selectedProbPoints">Список с выбранными точками проботбора.</param>
        /// <returns>Загрязнение в выбранной точке.</returns>
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
        /// Получить загрязнение за сезон.
        /// </summary>
        /// <param name="points">Матрица с загрязнениями в точках.</param>
        /// <returns>Загрязнение за сезон.</returns>
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
        /// Получить загрязнение за год.
        /// </summary>
        /// <param name="points">Загрязнение за сезон.</param>
        /// <param name="T">Количество дней.</param>
        /// <returns>Загрязнение за год.</returns>
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
        /// Получить радианы.
        /// </summary>
        /// <param name="x">Координаты.</param>
        /// <returns>Радианы.</returns>
        private double Radians(double x)
        {
            return x * Math.PI / 180;
        }

        /// <summary>
        /// Получить расстояние между двумя точками.
        /// </summary>
        /// <param name="lon1">Longtitude point 1.</param>
        /// <param name="lat1">Latitude point 1.</param>
        /// <param name="lon2">Longtitude point 2.</param>
        /// <param name="lat2">Latitude point 2.</param>
        /// <returns>Расстояние между двумя точками.</returns>
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