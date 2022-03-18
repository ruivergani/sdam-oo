namespace AbstractAccount
{
    public abstract class Account
    {
        public int SortCode { get; set; }
        public int AccountNumber { get; }
        public string AccountName { get; }

        public Account(int sc, int acNum, string acName)
        {
            this.SortCode = sc;
            this.AccountNumber = acNum;
            this.AccountName = acName;
        }

        public abstract override string ToString();
    }
}
