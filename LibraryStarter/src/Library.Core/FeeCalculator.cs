namespace Library.Core;

public class FeeCalculator
{
    private const decimal FeePerDay = 5m;
    private const decimal MaxFee = 100m;

    public decimal Calculate(DateTime due, DateTime returned)
    {
        int daysLate = (returned.Date - due.Date).Days;

        if (daysLate <= 0)
            return 0m;

        return Math.Min(daysLate * FeePerDay, MaxFee);
    }
}