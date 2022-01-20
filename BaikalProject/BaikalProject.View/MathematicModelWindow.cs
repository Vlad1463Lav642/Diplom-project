using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaikalProject.BL.Controller;
using BaikalProject.BL.Database;
using BaikalProject.BL.Model;
using BaikalProject.BL.Other;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

using ClosedXML.Excel;
using MaterialSkin.Controls;

namespace BaikalProject.View
{
    public partial class MathematicModelWindow : MaterialForm
    {

        #region Parametrs
        private const double mapX = 53.6946273;
        private const double mapY = 106.9142586;
        private const int maxZoom = 10;
        private const int minZoom = 6;
        private Brush brush;
        private int X;
        private int Y;
        private int zoom = 6;
        private IDatabase database;
        private IMathematicModel model;
        public Dictionary<string, MapPoint> dictionaryWithPoints;
        private Dictionary<string, PointLatLng> polygonPoints;
        private GMapOverlay mouseClickOverlay;
        private MapPoint[,] genericPoints;
        private PointLatLng mousePoint;
        private List<string> selectedProbPoints;
        private double resultSeason;
        private double resultYear;
        private string element;
        private double[,] resultPoint;
        private readonly MaterialSkin.MaterialSkinManager skinManager = null;
        private GMapOverlay mapOverlay = new GMapOverlay("pollution Pole");
        #endregion

        /// <summary>
        /// Window with map.
        /// </summary>
        public MathematicModelWindow()
        {
            InitializeComponent();

            database = new Database();
            dictionaryWithPoints = new Dictionary<string, MapPoint>();
            polygonPoints = new Dictionary<string, PointLatLng>();
            mouseClickOverlay = new GMapOverlay("MouseClicks");
            selectedProbPoints = new List<string>();
            resultPoint = new double[X, Y];

            model = new MathematicModel();

            X = model.GetMaxX();
            Y = model.GetMaxY();

            dictionaryWithPoints = database.GetCoordinates();
            genericPoints = model.GetMatrixPoints();

            elementsComboBox.SelectedIndex = 0;
            element = elementsComboBox.SelectedItem.ToString().Split(' ')[0];
            ElementUpdate();

            MainWindow.themeSelector(skinManager, this);
            ColorBoxes();
        }

        /// <summary>
        /// Open window with points.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pointsButton_Click(object sender, EventArgs e)
        {
            PointsWindow pointsWindow = new PointsWindow();
            pointsWindow.currentMathematicModelWindow = this;
            pointsWindow.Show();

            ColorBoxes();
        }

        /// <summary>
        /// Function for working with map.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void map_Load(object sender, EventArgs e)
        {
            map.Bearing = 0;
            map.CanDragMap = true;
            map.GrayScaleMode = true;
            map.MarkersEnabled = true;

            //Maximal zoom.
            map.MaxZoom = maxZoom;

            map.Dock = DockStyle.None;

            map.MapScaleInfoEnabled = true;

            //Minimal zoom.
            map.MinZoom = minZoom;

            //Mouse cursor in center of the map.
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;

            map.IgnoreMarkerOnMouseWheel = true;

            //Move while holding down the left mouse button.
            map.DragButton = MouseButtons.Left;

            map.NegativeMode = false;

            //Enable polygons.
            map.PolygonsEnabled = true;

            //Enable routes.
            map.RoutesEnabled = true;

            //Hide TileGridLines.
            map.ShowTileGridLines = false;

            //Default zoom.
            map.Zoom = zoom;

            //Hide cross in center of the map.
            map.ShowCenter = false;

            //Map provider.
            map.MapProvider = GMapProviders.ArcGIS_World_Topo_Map;

            //Loading map from server or cache.
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"Cache";

            //Coordinates for map.
            map.Position = new PointLatLng(mapX,mapY);

            map.Overlays.Clear();
            CreateProbMarkers();
        }

        /// <summary>
        /// Draw markers on map.
        /// </summary>
        private void CreateProbMarkers()
        {
            GMapOverlay markersOverlay = new GMapOverlay("Markers");
            Bitmap probMarker = new Bitmap(imageList1.Images[0]);
            polygonPoints.Clear();

            foreach (string key in dictionaryWithPoints.Keys)
            {
                polygonPoints.Add(key, new PointLatLng(dictionaryWithPoints[key].x, dictionaryWithPoints[key].y));
                GMapMyMarker marker = new GMapMyMarker(polygonPoints[key],probMarker);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = key;
                markersOverlay.Markers.Add(marker);
            }

            map.Overlays.Add(markersOverlay);
        }

        /// <summary>
        /// Select element in the database.
        /// </summary>
        public void ElementUpdate()
        {
            try
            {
                model.SetOilsAndElements(database.GetOilOrElements(element));
            }
            catch
            {
                string errorText = "Элемент загрязнения " + element + " не найден.";
                ErrorWindow.errorText = errorText;
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();
            }
        }

        /// <summary>
        /// Draw pollution polygon.
        /// </summary>
        /// <param name="selectedPoints">List with selected points.</param>
        public void DrawPolygon(List<string> selectedPoints)
        {
            Dictionary<string, PointLatLng> pointsDictionary = new Dictionary<string, PointLatLng>();
            Dictionary<string, double[,]> genericDistanceDictionary = new Dictionary<string, double[,]>();
            double[,] genericDistance = new double[X, Y];
            selectedProbPoints = selectedPoints;
            Dictionary<string, double> elements = database.GetOilOrElements(element);
            List<double> sortedSelectedPollutions = new List<double>();
            mapOverlay.Clear();

            foreach (string key in selectedPoints)
            {
                pointsDictionary.Add(key, polygonPoints[key]);

                sortedSelectedPollutions.Add(elements[key]);
            }
            sortedSelectedPollutions.Sort();

            foreach (string point in pointsDictionary.Keys)
            {
                for (int i = 0; i < X; i++)
                {
                    for (int j = 0; j < Y; j++)
                    {
                        genericDistance[i, j] = model.DistanceBetweenPlaces(pointsDictionary[point].Lng, pointsDictionary[point].Lat, genericPoints[i, j].y, genericPoints[i, j].x);
                    }
                }
                genericDistanceDictionary.Add(point, genericDistance);
                genericDistance = new double[X, Y];
            }
            model.SetDistance(genericDistanceDictionary);

            resultPoint = model.MathematicPoint(selectedPoints);
            resultSeason = model.MathematicSeason(resultPoint);
            resultYear = model.MathematicYear(resultSeason, 90);
            #region pollutionPolygons

            //Painting pollution polygon.

            Color darkRed = Color.FromArgb(60,139, 0, 0);
            Color red = Color.FromArgb(60,255, 0, 0);
            Color darkOrange = Color.FromArgb(70,239, 90, 0);
            Color orange = Color.FromArgb(60,255, 165, 0);
            Color darkYellow = Color.FromArgb(60,215, 200, 0);
            Color yellow = Color.FromArgb(60,255, 255, 0);
            Color darkGreen = Color.FromArgb(60,0, 100, 0);
            Color green = Color.FromArgb(60,0, 255, 0);

            double min = sortedSelectedPollutions[0];
            double max = sortedSelectedPollutions[sortedSelectedPollutions.Count - 1];

            double maxSumPollutions = 0;
            int timer = 0;

            foreach (double pollution in sortedSelectedPollutions)
            {
                maxSumPollutions += pollution;
                timer++;
            }
            double diapz = (max - min) / 8;

            double sAvg = min + diapz;
            double dsAvg = sAvg + diapz;
            double fsAvg = dsAvg + diapz;
            double avg = fsAvg + diapz;
            double sMax = avg + diapz;
            double dsMax = sMax + diapz;
            double fsMax = dsMax + diapz;


            double[] backupArr = new double[] { min,sAvg,dsAvg,fsAvg,avg,sMax,dsMax,fsMax,max};
            double backup;

            for(int i = 0; i < backupArr.Length; i++)
            {
                for(int j = 0; j < backupArr.Length - 1; j++)
                {
                    if(backupArr[j] < backupArr[j + 1])
                    {
                        backup = backupArr[j];
                        backupArr[j] = backupArr[j + 1];
                        backupArr[j + 1] = backup;
                    }
                }
            }

            min = backupArr[8];
            sAvg = backupArr[7];
            dsAvg = backupArr[6];
            fsAvg = backupArr[5];
            avg = backupArr[4];
            sMax = backupArr[3];
            dsMax = backupArr[2];
            fsMax = backupArr[1];
            max = backupArr[0];

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y - 1; j++)
                {
                    if (resultPoint[i, j] >= min && resultPoint[i, j] < sAvg)
                    {
                        brush = new SolidBrush(green);
                    }
                    else if (resultPoint[i, j] >= sAvg && resultPoint[i, j] < dsAvg)
                    {
                        brush = new SolidBrush(darkGreen);
                    }
                    else if (resultPoint[i, j] >= dsAvg && resultPoint[i, j] < fsAvg)
                    {
                        brush = new SolidBrush(yellow);
                    }
                    else if (resultPoint[i, j] >= fsAvg && resultPoint[i, j] < avg)
                    {
                        brush = new SolidBrush(darkYellow);
                    }
                    else if (resultPoint[i, j] >= avg && resultPoint[i, j] < sMax)
                    {
                        brush = new SolidBrush(orange);
                    }
                    else if (resultPoint[i, j] >= sMax && resultPoint[i, j] < dsMax)
                    {
                        brush = new SolidBrush(darkOrange);
                    }
                    else if (resultPoint[i, j] >= dsMax && resultPoint[i, j] < fsMax)
                    {
                        brush = new SolidBrush(red);
                    }
                    else if (resultPoint[i, j] >= fsMax && resultPoint[i, j] < max)
                    {
                        brush = new SolidBrush(darkRed);
                    }

                    GMapPointer pointer = new GMapPointer(new PointLatLng(genericPoints[i, j].x, genericPoints[i, j].y), brush, 5);

                    mapOverlay.Markers.Add(pointer);
                    map.Overlays.Add(mapOverlay);

                    if (element != "Hg")
                    {
                        greenLabel.Text = Math.Round(min, 4) + " <= x < " + Math.Round(sAvg, 4) + " мг/дм³";
                        darkGreenLabel.Text = Math.Round(sAvg, 4) + " <= x < " + Math.Round(dsAvg, 4) + " мг/дм³";
                        yellowLabel.Text = Math.Round(dsAvg, 4) + " <= x < " + Math.Round(fsAvg, 4) + " мг/дм³";
                        darkYellowLabel.Text = Math.Round(fsAvg, 4) + " <= x < " + Math.Round(avg, 4) + " мг/дм³";
                        orangeLabel.Text = Math.Round(avg, 4) + " <= x < " + Math.Round(sMax, 4) + " мг/дм³";
                        darkOrangeLabel.Text = Math.Round(sMax, 4) + " <= x < " + Math.Round(dsMax, 4) + " мг/дм³";
                        redLabel.Text = Math.Round(dsMax, 4) + " <= x < " + Math.Round(fsMax, 4) + " мг/дм³";
                        darkRedLabel.Text = Math.Round(fsMax, 4) + " <= x < " + Math.Round(max, 4) + " мг/дм³";
                    }
                    else
                    {
                        greenLabel.Text = Math.Round(min, 4) + " <= x < " + Math.Round(sAvg, 4) + " мкг/дм³";
                        darkGreenLabel.Text = Math.Round(sAvg, 4) + " <= x < " + Math.Round(dsAvg, 4) + " мкг/дм³";
                        yellowLabel.Text = Math.Round(dsAvg, 4) + " <= x < " + Math.Round(fsAvg, 4) + " мкг/дм³";
                        darkYellowLabel.Text = Math.Round(fsAvg, 4) + " <= x < " + Math.Round(avg, 4) + " мкг/дм³";
                        orangeLabel.Text = Math.Round(avg, 4) + " <= x < " + Math.Round(dsMax, 4) + " мкг/дм³";
                        darkOrangeLabel.Text = Math.Round(dsMax, 4) + " <= x < " + Math.Round(sMax, 4) + " мкг/дм³";
                        redLabel.Text = Math.Round(sMax, 4) + " <= x < " + Math.Round(fsMax, 4) + " мкг/дм³";
                        darkRedLabel.Text = Math.Round(fsMax, 4) + " <= x < " + Math.Round(max, 4) + " мкг/дм³";
                    }
                }
            }

            map.Overlays.Clear();

            map.Overlays.Add(mapOverlay);
            CreateProbMarkers();

            map.Width++;
            map.Width--;
            #endregion
        }

        /// <summary>
        /// Draw a marker where the right mouse button was pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if(mouseClickOverlay.Markers.Count > 0)
                {
                    mouseClickOverlay.Clear();
                }

                mousePoint = map.FromLocalToLatLng(e.X, e.Y);
                Bitmap mouseMarker = new Bitmap(imageList1.Images[1]);

                GMapMyMarker mouseClickPosition = new GMapMyMarker(mousePoint, mouseMarker);
                mouseClickPosition.ToolTip = new GMapRoundedToolTip(mouseClickPosition);
                mouseClickPosition.ToolTipText = "ClickPosition - " + Math.Round(map.FromLocalToLatLng(e.X,e.Y).Lat,4) + " : " + Math.Round(map.FromLocalToLatLng(e.X,e.Y).Lng,4);
                mouseClickOverlay.Markers.Add(mouseClickPosition);
                map.Overlays.Add(mouseClickOverlay);    
            }
        }

        /// <summary>
        /// Select element from combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElementsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            element = elementsComboBox.SelectedItem.ToString().Split(' ')[0];
            ElementUpdate();
        }

        /// <summary>
        /// Calculation of pollution at a point, per season and per year.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PollutionClick(object sender, EventArgs e)
        {
            if(selectedProbPoints.Count > 0)
            {
                if (element != "Hg")
                {
                    pointLabel.Text = "В точке: " + Math.Round(model.MathematicPoint(mousePoint.Lat, mousePoint.Lng, selectedProbPoints), 4) + " мг/дм³";
                    seasonLabel.Text = "В сезон: " + Math.Round(resultSeason, 4) + " мг/дм³";
                    yearLabel.Text = "В год: " + Math.Round(resultYear, 4) + " мг/дм³";
                }
                else
                {
                    pointLabel.Text = "В точке: " + Math.Round(model.MathematicPoint(mousePoint.Lat, mousePoint.Lng, selectedProbPoints), 4) + " мкг/дм³";
                    seasonLabel.Text = "В сезон: " + Math.Round(resultSeason, 4) + " мкг/дм³";
                    yearLabel.Text = "В год: " + Math.Round(resultYear, 4) + " мкг/дм³";
                }
            }
        }

        /// <summary>
        /// Save screenshot of map.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenButton_Click(object sender, EventArgs e)
        {
            try
            {
                using(SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.FileName = "Map_Image.png";
                    dialog.Filter = "PNG (*.png)|*.png";
                    Image image = map.ToImage();
                    if(dialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = dialog.FileName;
                        image.Save(fileName);
                        MessageBox.Show("Скриншот карты сохранен.");
                    }
                }
            }
            catch
            {
                ErrorWindow.errorText = "Ошибка при сохранении скриншота карты.";
                ErrorWindow error = new ErrorWindow();
                error.Show();
            }
        }

        /// <summary>
        /// Save Excel file with data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    if (X > 0 && resultPoint.Length > 0)
                    {
                        dialog.FileName = "resultExcel.xlsx";
                        dialog.Filter = "XLSX (*.xlsx)|*.xlsx";
                        XLWorkbook workbook = new XLWorkbook();
                        var worksheet = workbook.Worksheets.Add("Результат");

                        for (int j = 0; j < X; j++)
                        {
                            for (int k = 0; k < Y; k++)
                            {
                                worksheet.Cell(j + 2, k + 1).Value = resultPoint[j, k];
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        worksheet.Rows().AdjustToContents();

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            workbook.SaveAs(fileName);
                            MessageBox.Show("Excel файл сохранен.");
                        }
                    }
                }
            }
            catch
            {
                ErrorWindow.errorText = "Ошибка при экспорте данных в Excel.";
                ErrorWindow error = new ErrorWindow();
                error.Show();
            }
        }

        /// <summary>
        /// Open help window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            IHelperStorage helperStorage = new HelperStorage();
            HelpWindow help = HelpWindow.GetInstance();
            help.SetText(helperStorage.GetDataString("MathematicModelWindow"));
            help.Show();

            ColorBoxes();
        }

        /// <summary>
        /// Draw color markers.
        /// </summary>
        private void ColorBoxes()
        {
            darkRedPanel.BackColor = Color.FromArgb(139, 0, 0);
            redPanel.BackColor = Color.FromArgb(255, 0, 0);
            darkOrangePanel.BackColor = Color.FromArgb(239, 90, 0);
            orangePanel.BackColor = Color.FromArgb(255, 165, 0);
            darkYellowPanel.BackColor = Color.FromArgb(215, 200, 0);
            yellowPanel.BackColor = Color.FromArgb(255, 255, 0);
            darkGreenPanel.BackColor = Color.FromArgb(0, 100, 0);
            greenPanel.BackColor = Color.FromArgb(0, 255, 0);
        }

        /// <summary>
        /// Hide pollution polygon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HidePollutionBox_CheckedChanged(object sender, EventArgs e)
        {
            map.Overlays.Clear();

            if(hidePollutionBox.Checked == false)
            {
                map.Overlays.Add(mapOverlay);
                CreateProbMarkers();
            }
            else
            {
                CreateProbMarkers();
            }
            map.Width++;
            map.Width--;
            map.Position = new PointLatLng(mapX, mapY);
        }
    }
}