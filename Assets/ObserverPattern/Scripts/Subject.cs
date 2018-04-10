using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
	//A list with observers that are waiting for something to happen
	[SerializeField]
	private List<IObserver> _observers = new List<IObserver>();

    //Send notifications if something has happened
    public void Notify()
    {
        for (int i = 0; i < _observers.Count; i++)
        {
            //Notify all observers even though some may not be interested in what has happened
            //Each observer should check if it is interested in this event
            _observers[i].Notify();
        }
    }

    //Add observer to the list
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    //Remove observer from the list
    public void RemoveObserver(IObserver observer)
    {
		_observers.Remove (observer);
    }
}
