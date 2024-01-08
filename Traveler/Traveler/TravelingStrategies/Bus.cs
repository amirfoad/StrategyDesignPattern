namespace Traveler.TravelingStrategies;

public class Bus : TravelerStrategy
{
    public Bus()
    {
        KilometerCost = 20;
    }
    public override decimal Drive(int kilometers)
    {
        return kilometers * KilometerCost;
    }
}