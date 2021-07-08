using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherData : Subject
    {

        private List<Observer> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            
        }        
        
        public void NotifyObservers()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }
    }
}