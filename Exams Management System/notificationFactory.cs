using System.Collections.Generic;

namespace Exams_Management_System
{
    class notificationFactory
    {
        public List <Notification> createNotification(string message, List<string> types)
        {
            List<Notification> notificationsList=new List<Notification>();
            {
                for (int i = 0; i < types.Count; i++)
                {
                    if (types[i] == "Email")
                    {

                        Notification email = new emailNotification(message);
                        notificationsList.Add(email);
                    }
                    else if (types[i] == "SMS")
                    {
                        Notification SMS = new SMSNotification(message);
                        notificationsList.Add(SMS);
                    }
                    else if (types[i] == "WhatsApp")
                    {
                        Notification WhatsApp = new whatsAppNotification(message);
                        notificationsList.Add(WhatsApp);
                    }

                }
                return notificationsList;
            }
        }
    }
}
