using AndroidX.Activity;
using Com.Stripe.Android.Paymentsheet;
using Com.Stripe.Android.Paymentsheet.Model;

namespace Stripe.MAUI
{
    // All the code in this file is included in all platforms.
    public class StripePaymentHandler
    {
        public void ShowPaymentSheet()
        {
#if ANDROID

            if (Platform.CurrentActivity is not ComponentActivity activity)
            {
                return;
            }

            var paymentSheet = new PaymentSheet(activity, new PaymentSheetCallback());
#endif
        }

#if ANDROID
        public class PaymentSheetCallback : Java.Lang.Object, IPaymentSheetResultCallback
        {
            public void OnPaymentSheetResult(PaymentSheetResult paymentSheetResult)
            {
                throw new NotImplementedException();
            }
        }
#endif
    }
}
