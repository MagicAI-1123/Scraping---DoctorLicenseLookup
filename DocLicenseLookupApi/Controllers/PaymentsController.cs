using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace DocLicenseLookupApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentsController : Controller
    {
        private const string _stripeSecretKey = "sk_test_51IiGnLFp9n2Qz5LtMBNCBmd2te2dosoEbddag6W58hBeXJk6pd6ylWe1snt7udR0Gg9nnnmWhHdPRggwcEjGI6MA003cSjA295";

        public PaymentsController()
        {
            StripeConfiguration.ApiKey = _stripeSecretKey;
        }

        [HttpGet(Name = "CreatePaymentIntent")]
        public async Task<string> CreatePaymentIntent(long amount)
        {  
                var options = new PaymentIntentCreateOptions
                {
                    Amount = amount * 100,// Convert amount to cents
                    Currency = "usd"
                };

                var service = new PaymentIntentService();
                var paymentIntent = await service.CreateAsync(options);

            return paymentIntent.ClientSecret;      
        }
    }
}
