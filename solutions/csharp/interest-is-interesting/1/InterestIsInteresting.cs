static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance >= 0 && balance < 1000)
        {
            return 0.5f;
        }
        else if (balance >= 1000 && balance <5000)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        decimal rate = (decimal)InterestRate(balance)/100;
        return balance * rate;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal rate = Interest(balance);
        return balance + rate;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
