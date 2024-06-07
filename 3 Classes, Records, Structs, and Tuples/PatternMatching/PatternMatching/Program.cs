using static TrafficLight;

var previousLight1 = Red;
var currentLight1 = Red;

for (int i = 0; i < 10; i++)
{
    (currentLight1, previousLight1) = NextLightUsingTuples(currentLight1, previousLight1);

    Console.WriteLine($"{currentLight1}");

    await Task.Delay(1000);
}

TrafficLightState currentLightState1 = new(AmberBlink, AmberBlink, 2000);

for (int i = 0; i < 20; i++)
{
    currentLightState1 = NextLightUsingRecords(currentLightState1);

    Console.WriteLine($"{currentLightState1.CurrentLight}, {currentLightState1.Milliseconds}.");

    await Task.Delay(currentLightState1.Milliseconds);
}

// A tuple pattern with a discard.
(TrafficLight Current, TrafficLight Previous) NextLightUsingTuples(TrafficLight current, TrafficLight previous) =>
    (current, previous) switch
    {
        (Red, _) => (Amber, current),
        (Amber, Red) => (Green, current),
        (Green, _) => (Amber, current),
        (Amber, Green) => (Red, current),
        _ => throw new InvalidOperationException()
    };

// A property pattern with relational patterns.
TrafficLightState NextLightUsingRecords(TrafficLightState trafficLightState) =>
    trafficLightState switch
    {
        { CurrentLight: AmberBlink } => new TrafficLightState(Red, trafficLightState.PreviousLight, 3000),
        { CurrentLight: Red } => new TrafficLightState(Amber, trafficLightState.CurrentLight, 200),
        { CurrentLight: Amber, PreviousLight: Red } => new TrafficLightState(Green, trafficLightState.CurrentLight, 2000),
        { CurrentLight: Green } => new TrafficLightState(GreenBlink, trafficLightState.CurrentLight, 100, 1),
        { CurrentLight: GreenBlink, BlinkCount: < 3 } => trafficLightState with { BlinkCount = trafficLightState.BlinkCount + 1 },
        { CurrentLight: GreenBlink } => new TrafficLightState(Amber, trafficLightState.CurrentLight, 200),
        { CurrentLight: Amber, PreviousLight: GreenBlink } => new TrafficLightState(Red, trafficLightState.CurrentLight, 3000),
        _ => throw new InvalidOperationException()
    };

public enum TrafficLight
{
    Red,
    Amber,
    Green,
    GreenBlink,
    AmberBlink
}

public record TrafficLightState(TrafficLight CurrentLight, TrafficLight PreviousLight, int Milliseconds, int BlinkCount = 0);
