namespace Traveler;

public abstract class TravelerStrategy
{
    public int KilometerCost;
    public abstract decimal Drive(int kilometers);
}