using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NHopfild.Model
{
    class Brush
    {
        SolidBrush solidBrush = new SolidBrush(Color.White);
        public int Radius
        { get; set; }

        public Brush(int radius)
        {
            Radius = radius;
        }

        public void Draw(Graphics gr, int MousePositionX, int MousePositionY, Color color)
        {
            solidBrush.Color = color;
            gr.FillEllipse(solidBrush, MousePositionX - Radius, MousePositionY - Radius, 2 * Radius, 2 * Radius);
        }
    }
}
