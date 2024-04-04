using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Without DIP
    public class NotificationService1
    {
        public void SendNotification(string message)
        {
            EmailSender send = new EmailSender();
            send.SendEmail(message);
        }
    }

    public class EmailSender
    {
        public void SendEmail(string message)
        {
            Console.WriteLine(message);
        }
    }
    //With DIP
    public interface INotificationSender
    {
        void SendNotification(string message);
    }

    public class EmailSender1 : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class NotificationService
    {
        private INotificationSender notificationSender;

        public NotificationService(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public void SendNotification(string message)
        {
            notificationSender.SendNotification(message);
        }
    }
}
