

namespace FoodDeliveryNotificationSystem
{
    public delegate void NotificationDelegate();

    internal class FoodDeliverySystem
    {
        public void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }

        public void SendSMS()
        {
            Console.WriteLine("SMS Sent");
        }

        public void SendWhatsApp()
        {
            Console.WriteLine("WhatsApp Notification Sent");
        }
        public void OrderPlaced()
        {
            Console.WriteLine("Order Placed");

            NotificationDelegate notify = SendEmail;

            notify += SendSMS;
            notify += SendWhatsApp;

            
            notify();
        }
    }
}
