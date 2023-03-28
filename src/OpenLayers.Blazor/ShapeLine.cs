﻿namespace OpenLayers.Blazor;

public class ShapeLine : Shape
{
    private IEnumerable<Coordinate> _points;

    public ShapeLine()
    {
        Geometry = new Geometry("LineString");
    }

    public ShapeLine(params Coordinate[] point)
    {
        Geometry = new Geometry("LineString");
        Points = new List<Coordinate>(point);
    }

    public IEnumerable<Coordinate> Points
    {
        get => _points;
        set
        {
            _points = value;
            Geometry.Coordinates = value?.Select(x => x.Coordinates);
        }
    }
}