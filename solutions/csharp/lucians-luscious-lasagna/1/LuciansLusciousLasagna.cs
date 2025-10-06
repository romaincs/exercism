class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int m) => ExpectedMinutesInOven() - m ;
    public int PreparationTimeInMinutes(int l) => l*2;
    public int ElapsedTimeInMinutes(int l, int m) => PreparationTimeInMinutes(l) + m;
}
