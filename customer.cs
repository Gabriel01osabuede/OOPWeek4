namespace week4class
{
    public class customer
    {
        decimal _customerAmount = 1000M;
        decimal _Amount;


        public customer(decimal Amount)
        {
            _Amount = Amount;
        }

     
        public decimal credit()
        {
            
            return _customerAmount += _Amount;
        }

        public decimal debit()
        {
         
            return _customerAmount -= _Amount;
        }
        public decimal balance()
        {
            return this._customerAmount;
        }
    }
}