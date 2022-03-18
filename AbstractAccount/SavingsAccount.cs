namespace AbstractAccount
{
    public class SavingsAccount : Account
    {
        private double interestRate;
        public double InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                if (value >= 0)
                {
                    interestRate = value;
                }
            }
        }

        public SavingsAccount(int sc, int acNum, string acName, double intRate) : base(sc, acNum, acName)
        {
            this.InterestRate = intRate;
        }

        public override string ToString()
        {
            return string.Format(
                "Savings Account\n\tSort code: {0}\n\tA/c number: {1}\n\tA/c name: {2}\n\tInterest rate: {3}",
                SortCode,
                AccountNumber,
                AccountName,
                InterestRate);
        }
    }
}
