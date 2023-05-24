using System;

class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                this.width = value;
        }
    }

    public int Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                this.height = value;
        }
    }

    public new int Area()
    {
        return this.width * this.height;
    }

    public override string ToString()
    {
        return $"[{this.GetType().Name}] {this.width} / {this.height}";
    }
}

class Square : Rectangle
{
    private int size;

    public int Size
    {
        get
        {
            return this.size;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                this.size = value;
                this.Height = value;
                this.Width = value;
            }
        }

    }
}