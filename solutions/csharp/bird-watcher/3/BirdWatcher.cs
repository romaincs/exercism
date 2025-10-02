class BirdCount
{
    private int[] birdsPerDay;
    private int todayCount;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0,2,5,3,7,8,4];

    public int Today() => birdsPerDay[birdsPerDay.Length-1] + todayCount;

    public void IncrementTodaysCount()
    {
        todayCount++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int i in birdsPerDay) {
            if(i == 0) {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i=0; i<numberOfDays;i++) {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        int sum=0;
        foreach(int i in birdsPerDay) {
            if(i>4) {
                sum++;
            }
        }
        return sum;
    }
}
