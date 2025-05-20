using System;
using UnityEngine;

public class ObserverUI : MonoBehaviour
{
    private void OnEnable()
    {
        ObserverManager.Instance.AddObserverListener(Function);
    }

    private void OnDisable()
    {
        ObserverManager.Instance.RemoveObserverListener(Function);
    }
    
    private void Function(int num)
    {
        Debug.Log(num);
    }
}
