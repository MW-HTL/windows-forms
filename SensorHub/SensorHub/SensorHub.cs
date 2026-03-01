using System;
using System.Collections.Generic;

namespace SensorHub
{
    public sealed class Unsubscriber<T> : IDisposable
    {
        private readonly List<IObserver<T>> Observers;
        private readonly IObserver<T> Observer;

        public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            Observers = observers;
            Observer = observer;
        }

        public void Dispose()
        {
            if (Observers.Contains(Observer))
            {
                Observers.Remove(Observer);
            }
        }
    }

    // SensorHub class: provides an observable (= beobachtbar)
    public class SensorHub : IObservable<SensorReading>
    {
        private List<IObserver<SensorReading>> observers;       // list of subscribed observers
        private System.Windows.Forms.Timer timer;
        private Random rnd;                                     // used for random data generation
        private int seq;                                        // number of reading/measurement

        public SensorHub(int intervalMs)
        {
            observers = new List<IObserver<SensorReading>>();
            rnd = new Random();
            seq = 0;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = intervalMs;
            timer.Tick += Timer_Tick;                           // adds the Tick event
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Emit();
        }

        public IDisposable Subscribe(IObserver<SensorReading> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber<SensorReading>(observers, observer);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();

            foreach (IObserver<SensorReading> obs in observers.ToArray())
            {
                obs.OnCompleted();
            }
        }

        // Emit: tells all observers that a new reading r has just arrived
        private void Emit()
        {
            double temperature = 12.0 + rnd.NextDouble() * 20.0;

            seq++;
            SensorReading r = new SensorReading(DateTime.Now, seq, temperature);

            foreach (IObserver<SensorReading> obs in observers.ToArray())
            {
                obs.OnNext(r);
            }
        }
    }
}
