using Aluguel_Interface.Services;

namespace Alugel_SemInterface.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}