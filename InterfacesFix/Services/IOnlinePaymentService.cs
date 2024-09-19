namespace InterfacesFix.Services
{
    internal interface IOnlinePaymentService
    {
        public double paymentFee(double amount);

        public double Interest(double amount, int months);
        
    }
}
