using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum MonsterType
{
    FIRST,
    SECOND,
}
public class Factory : MonoBehaviour
{
    [SerializeField] private List<MonsterData> _monsterDataList;
    private Dictionary<MonsterType, MonsterData> _monsterDatas = new Dictionary<MonsterType, MonsterData>();

    private void Awake()
    {
        InitMonsterData();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SpawnMonster(MonsterType.FIRST);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            SpawnMonster(MonsterType.SECOND);
        }
    }

    private void InitMonsterData()
    {
        for (int i = 0; i < _monsterDataList.Count; i++)
        {
            _monsterDatas[_monsterDataList[i].type] = _monsterDataList[i];
        }
    }

    
    private void SpawnMonster(MonsterType type)
    {
        if (!_monsterDatas.TryGetValue(type, out var data))
        {
            Debug.LogError($"MonsterData for type {type} not found!");
            return;
        }

        //생성 코드 추가
        //Instantiate()
        
        Debug.Log(data.name);
    }
}
