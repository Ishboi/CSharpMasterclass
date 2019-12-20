using System;

namespace EventsAndDelegatesC
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Notify user that download is done..." + e.File.Title);
        }
    }


}
