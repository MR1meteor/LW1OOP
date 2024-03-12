namespace LW1.EventArgsModels
{
    public class EventArgsModel(string message) : EventArgs
    {
        public string Message { get; set; } = message;
    }
}
