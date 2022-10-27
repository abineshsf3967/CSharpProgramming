namespace SampleEvent
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;
        public static int i;

        public Events(string eventName)
        {
            _eventName=eventName;
        }

        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting following events");
            eventlink();
        }

        public void StartEvent()
        {
            ++i;
            System.Console.WriteLine($"Event No {i} is {_eventName} started");
        }
    }
}