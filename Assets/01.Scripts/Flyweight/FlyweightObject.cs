using UnityEngine;
using UnityEngine.Serialization;

public class FlyweightObject : MonoBehaviour
{
    public FlyweightData FlyweightData;

    public void SetFlyweightData(FlyweightData data)
    {
        FlyweightData = data;
        Debug.Log(FlyweightData.FlyweightName);
    }
}
