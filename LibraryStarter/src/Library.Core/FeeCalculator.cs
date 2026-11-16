namespace Library.Core;

public class FeeCalculator
{
    public decimal Calculate(DateTime due, DateTime returned)
    {
        int daysLate = (returned.Date - due.Date).Days;

        if (daysLate <= 0)
            return 0m;

        return Math.Min(daysLate * 5m, 100m);
    }
}