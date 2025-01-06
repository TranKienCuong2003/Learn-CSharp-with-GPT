using System;

namespace AdvancedTopics
{
    public class DelegatesAndEvents
    {
        public delegate void Notify();  // Dinh nghia delegate

        public static void Run()
        {
            Notify notify = new Notify(SendMessage);
            notify(); // Goi delegate

            EventPublisher publisher = new EventPublisher();
            publisher.MyEvent += new EventHandler(OnEventRaised);
            publisher.RaiseEvent();
        }

        public static void SendMessage()
        {
            Console.WriteLine("Tin nhan da duoc gui!");
        }

        public static void OnEventRaised(object sender, EventArgs e)
        {
            Console.WriteLine("Su kien da duoc kich hoat.");
        }
    }

    public class EventPublisher
    {
        public event EventHandler MyEvent;

        public void RaiseEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
