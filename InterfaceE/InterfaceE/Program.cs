using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceE
{

    public interface INotifications
    {
        // Members
        void showNotification();
        string getDate();
    }

    public class Notification:INotifications
    {

        private string sender;
        private string message;
        private string date;

        // Default constructor
        public Notification()
        {
            sender = "Admin";
            message = "What's up?";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void showNotification()
        {
            Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
        }

        public string getDate()
        {
            return date;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Fabio", "Sup man?", "25.10.2019");
            Notification n2 = new Notification("Rocky", "WEEEEEEH", "25.10.2019");
            n1.showNotification();
            n2.showNotification();
            Console.ReadKey();
        }
    }
}
