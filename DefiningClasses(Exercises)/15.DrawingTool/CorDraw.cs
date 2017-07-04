using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CorDraw
{
    public Figure Figure { get; set; }

    public CorDraw(Figure figure)
    {
        this.Figure = figure;
    }

    public void DrawFigure()
    {
        this.Figure.Draw();
    }
}
