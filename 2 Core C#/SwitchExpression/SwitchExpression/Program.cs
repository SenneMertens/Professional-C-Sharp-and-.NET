string? input1 = Console.ReadLine();
string result1 = input1 switch
{
    "One" => "The input value was One.",
    "Two" or "Three" => "The input value was Two or Three.",
    _ => "Any other value"
};
Console.WriteLine(result1);

var trafficLight1 = TrafficLight.Red;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(trafficLight1);
    trafficLight1 = SwitchStatementWithReturn(trafficLight1);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(trafficLight1);
    trafficLight1 = SwitchExpression(trafficLight1);
}

TrafficLight SwitchStatementWithReturn(TrafficLight trafficLight1)
{
    switch (trafficLight1)
    {
        case TrafficLight.Green:
            return TrafficLight.Amber;
        case TrafficLight.Amber:
            return TrafficLight.Red;
        case TrafficLight.Red:
            return TrafficLight.Green;
        default:
            throw new InvalidOperationException();
    }
}

TrafficLight SwitchExpression(TrafficLight trafficLight1) =>
    trafficLight1 switch
    {
        TrafficLight.Green => TrafficLight.Amber,
        TrafficLight.Amber => TrafficLight.Red,
        TrafficLight.Red => TrafficLight.Green,
        _ => throw new InvalidOperationException()
    };

enum TrafficLight
{
    Red,
    Amber,
    Green
}
