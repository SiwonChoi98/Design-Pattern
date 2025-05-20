using Unity.VisualScripting;
using UnityEngine;

public class SampleSingleton : MonoBehaviour
{
    private void Start()
    {
        SingletonManager.Instance.Print();
    }
}
