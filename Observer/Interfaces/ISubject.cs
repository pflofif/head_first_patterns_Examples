﻿namespace Observer.Interfaces;

public interface ISubject
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObserver();
}