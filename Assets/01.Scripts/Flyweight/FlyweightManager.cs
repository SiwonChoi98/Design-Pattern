using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class FlyweightManager : MonoBehaviour
{
    [SerializeField] private FlyweightObject _baseFlyweightObject;
    [SerializeField] private List<FlyweightData> _flyweightDatas;
    
    private FlyweightObject _spawnFlyweightObject;
    private void Start()
    {
        SpawnFlyweightObject();
    }

    private void Update()
    {
        if (_spawnFlyweightObject == null)
            return;

        if (Input.GetKeyDown(KeyCode.L))
        {
            _spawnFlyweightObject.SetFlyweightData(_flyweightDatas[0]);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            _spawnFlyweightObject.SetFlyweightData(_flyweightDatas[1]);
        }
    }

    private void SpawnFlyweightObject()
    {
        GameObject gameObject = Instantiate(_baseFlyweightObject.gameObject);
        
        FlyweightObject flyweightObject = gameObject.GetComponent<FlyweightObject>(); 
        
        _spawnFlyweightObject = flyweightObject;
        _spawnFlyweightObject.SetFlyweightData(_flyweightDatas[0]);
    }
}
