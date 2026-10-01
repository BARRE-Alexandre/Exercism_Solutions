static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interest = 0.0f;
        if (balance < 0) {
            interest = 3.213f;
        }
        else if (balance >= 0 && balance < 1000) {
            interest = 0.5f;
        }
        else if (balance >= 1000 && balance < 5000) {
            interest = 1.621f;
        }
        else {
            interest = 2.475f;
        }
        return interest;
    }

    public static decimal Interest(decimal balance) => 
        (decimal)InterestRate(balance) * balance / 100;

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while(balance < targetBalance) {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        
        return years;
    }
}
