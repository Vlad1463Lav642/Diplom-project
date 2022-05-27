using BaikalProject.BL.Other;
using System.Collections.Generic;

namespace BaikalProject.BL.Controller
{
    public interface IMathematicModel
    {
        /// <summary>
        /// Получить матрицу загрязнений.
        /// </summary>
        /// <param name="selectedProbPoints">Список с выбранными точками проботбора.</param>
        /// <returns>Матрица с загрязнениями.</returns>
        double[,] MathematicPoint(List<string> selectedProbPoints);

        /// <summary>
        /// Задать элементы в точках проботбора.
        /// </summary>
        /// <param name="elements">Словарь с элементами.</param>
        void SetOilsAndElements(Dictionary<string, double> elements);

        /// <summary>
        /// Задать дистанцию от выбранной точки поля до точки проботбора.
        /// </summary>
        /// <param name="distance">Словарь с дистанциями.</param>
        void SetDistance(Dictionary<string, double[,]> genericDistanceDictionary);

        /// <summary>
        /// Получить матрицу со всеми точками поля.
        /// </summary>
        /// <returns>Матрица с точками.</returns>
        MapPoint[,] GetMatrixPoints();

        /// <summary>
        /// Получить загрязнение за сезон.
        /// </summary>
        /// <param name="points">Матрица с загрязнениями в точках.</param>
        /// <returns>Загрязнение за сезон.</returns>
        double MathematicSeason(double[,] points);

        /// <summary>
        /// Получить загрязнение за год.
        /// </summary>
        /// <param name="points">Загрязнение за сезон.</param>
        /// <param name="T">Количество дней.</param>
        /// <returns>Загрязнение за год.</returns>
        double MathematicYear(double points, int T);

        /// <summary>
        /// Получить X координату поля загрязнений.
        /// </summary>
        /// <returns>X координата.</returns>
        int GetMaxX();

        /// <summary>
        /// Получить Y координату поля загрязнений.
        /// </summary>
        /// <returns>Y координата.</returns>
        int GetMaxY();

        /// <summary>
        /// Получить загрязнение в выбранной точке.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <param name="selectedProbPoints">Список с выбранными точками проботбора.</param>
        /// <returns>Загрязнение в выбранной точке.</returns>
        double MathematicPoint(double x, double y, List<string> selectedProbPoints);

        /// <summary>
        /// Получить расстояние между двумя точками.
        /// </summary>
        /// <param name="lon1">Longtitude point 1.</param>
        /// <param name="lat1">Latitude point 1.</param>
        /// <param name="lon2">Longtitude point 2.</param>
        /// <param name="lat2">Latitude point 2.</param>
        /// <returns>Расстояние между двумя точками.</returns>
        double DistanceBetweenPlaces(double lon1, double lat1, double lon2, double lat2);
    }
}