﻿using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
    
    public double Length
    {
        get
        {
            return this.length;
        }
        private set
        {
            if (value <= 0)
            {
                var message = "Length cannot be zero or negative.";
                throw new ArgumentException(message);
            }

            this.length = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
       private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = value;
        }
    }

    public double SurfaceArea
    {
        get
        {
            return (2 * this.length * this.width) +
                   (2 * this.length * this.height) +
                   (2 * this.width * this.height);
        }
    }

    public double LateralSurfaceArea
    {
        get
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }
    }

    public double Volume
    {
        get
        {
            return this.length * this.width * this.height;
        }
    }
}