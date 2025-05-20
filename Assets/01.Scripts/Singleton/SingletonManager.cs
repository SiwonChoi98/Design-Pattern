using System;
using UnityEngine;

public class SingletonManager : Singleton<SingletonManager>
{
    public void Print()
    {
        Debug.Log("Singleton Manager");
    }
}
