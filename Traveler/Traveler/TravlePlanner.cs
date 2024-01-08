namespace Traveler;

public class TravelPlanner
{
    private TravelerStrategy _travelerStrategy;

    public void SetTravelStrategy(TravelerStrategy travelerStrategy)
    {
        _travelerStrategy = travelerStrategy;
    }

    public void Drive(int kilometers)
    {
        var cost = _travelerStrategy.Drive(kilometers);
        Console.WriteLine($"Cost of the drive: {cost}");
    }
}