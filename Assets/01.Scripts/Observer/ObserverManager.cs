using System;
using UnityEngine;

public class ObserverManager : Singleton<ObserverManager>
{
    private Action<int> _observerAction;

    public void AddObserverListener(Action<int> action)
    {
        _observerAction = action;
    }

    public void RemoveObserverListener(Action<int> action)
    {
        _observerAction -= action;
    }

    public void AllRemoveObserverListener()
    {
        _observerAction = null;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintNumFunction(1);
        }
    }

    private void PrintNumFunction(int num)
    {
        _observerAction?.Invoke(num);
    }
}
