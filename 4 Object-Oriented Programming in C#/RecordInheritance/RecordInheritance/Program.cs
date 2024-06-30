using RecordInheritance;

Rectangle rectangle1 = new Rectangle(new Position(33, 22), new Size(200, 100));
Rectangle rectangle2 = rectangle1 with { Position = new Position(100, 22) };
Ellipse ellipse1 = new Ellipse(new Position(122, 200), new Size(40, 20));

DisplayShapes(rectangle1, rectangle2 , ellipse1);

void DisplayShapes(params Shape[] shapes)
{
    foreach (var shape in shapes)
    {
        shape.Draw();
    }
}
