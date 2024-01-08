namespace Traveler.TravelingStrategies;

public class Car : TravelerStrategy
{
    public Car()
    {
        KilometerCost = 25;
    }
    public override decimal Drive(int kilometers)
    {
        return kilometers * KilometerCost;
    }
}