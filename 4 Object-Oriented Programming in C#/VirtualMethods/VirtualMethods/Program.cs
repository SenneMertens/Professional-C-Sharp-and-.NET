using VirtualMethods;

Rectangle rectangle1 = new();

rectangle1.Position.X = 33;
rectangle1.Position.Y = 22;
rectangle1.Size.Width = 200;
rectangle1.Size.Height = 100;

Rectangle rectangle2 = rectangle1.Clone();

rectangle2.Position.X = 300;

Ellipse ellipse1 = new();

ellipse1.Position.X = 122;
ellipse1.Position.Y = 200;
ellipse1.Size.Width = 40;
ellipse1.Size.Height = 20;

DisplayShapes(rectangle1, rectangle2, ellipse1);

rectangle1.Move(new Position { X = 120, Y = 40 });

void DisplayShapes(params Shape[] shapes)
{
    foreach (Shape shape in shapes)
    {
        shape.Draw();
    }
}
