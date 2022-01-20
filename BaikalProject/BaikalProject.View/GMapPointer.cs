using System.Drawing;

using GMap.NET;
using GMap.NET.WindowsForms;

namespace BaikalProject.View
{
    class GMapPointer : GMapMarker
    {
        private float _size;
        private Brush _brush;
        private PointLatLng _point;



        public GMapPointer(PointLatLng p, Brush brush,float size) : base(p)
        {
            _brush = brush;
            _point = p;
            _size = size;
        }
        public override void OnRender(Graphics g)
        {
            g.FillRectangle(_brush, LocalPosition.X, LocalPosition.Y, _size, _size);
        }
    }
}