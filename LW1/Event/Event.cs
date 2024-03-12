using LW1.EventArgsModels;
using LW1.External;
using LW1.Forms;

namespace LW1.Event
{
    public class EventListener
    {
        public EventListener() {
            MainForm.OnEvent += HandleEvent;
        }

        public void HandleEvent(object? sender, EventArgsModel e)
        {
            Win32.MessageBox(0, e.Message, "Event", 0);
        }

    }
}
