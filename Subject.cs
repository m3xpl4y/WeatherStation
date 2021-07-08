using System;

namespace WeatherStation
{
    public interface Subject
    {
         void RegisterObserver(Observer o);
         void RemoveObserver(Observer o);
         void NotifyObservers();
    }
}