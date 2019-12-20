using System;

namespace EventsAndDelegatesC
{
    public interface IUnpackService
    {
        void OnFileDownloaded(object source, EventArgs e);
    }
}