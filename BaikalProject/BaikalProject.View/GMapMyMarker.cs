using System.Drawing;

using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace BaikalProject.View
{
    class GMapMyMarker : GMarkerGoogle
    {
        #region Parametrs
        private Bitmap _image;
        #endregion

        public GMapMyMarker(PointLatLng point, Bitmap image) : base(point, image)
        {
            _image = image;
        }

        public override void OnRender(Graphics g)
        {
            g.DrawImage(_image, LocalPosition.X, LocalPosition.Y+10, Size.Width,Size.Height);
        }
    }
}