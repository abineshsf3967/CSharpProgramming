using System;
namespace SampleEvent;
class Program
{
    public static void Main(string[] args)
    {
        Events event1=new Events("PaperPresentation");
        Events event2=new Events("Quiz");
        Events event3=new Events("Debugging");
        Events event4=new Events("Game");

        Events.eventlink+=new EventManager(event1.StartEvent);
        Events.eventlink+=new EventManager(event2.StartEvent);
        Events.eventlink+=new EventManager(event3.StartEvent);
        Events.eventlink+=new EventManager(event4.StartEvent);


        Events.HandleEvent();



        Events.eventlink-=new EventManager(event4.StartEvent);



    }
}
