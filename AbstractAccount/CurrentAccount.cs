namespace AbstractAccount
{
    public class CurrentAccount : Account
    {
        private double overdraftLimit;
        public double OverdraftLimit
        {
            get
            {
                return overdraftLimit;
            }

            set
            {
                if (value >= 0)
                {
                    overdraftLimit = value;
                }
            }
        }

        public CurrentAccount(int sc, int acNum, string acName, double overdraftLimit) : base(sc, acNum, acName)
        {
            this.OverdraftLimit = overdraftLimit;
        }

        public override string ToString()
        {
            return string.Format(
                "Current Account\n\tSort code: {0}\n\tA/c number: {1}\n\tA/c name: {2}\n\tOverdraft limit: {3}",
                SortCode,
                AccountNumber,
                AccountName,
                OverdraftLimit);
        }
    }
}
