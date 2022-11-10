namespace WebAPI.Services.Lab03
{
    public class Rectangle: Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static Rectangle operator + (Rectangle a, Rectangle b)
        {
            return new Rectangle(a.Width + b.Width, a.Height + b.Height);
        }

        public override int GetShorterSide()
        {
            return base.GetShorterSide();
        }
    }
}
