using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData", menuName = "Game/MonsterData")]
public class MonsterData : ScriptableObject
{
    public MonsterType type;
    public string name;
    
    //각 몬스터의 prefab 을 사용할 수도 있고, 아니면 GameObject는 1개로 데이터 안에 sprite등 animation을 교체해주는 방식도 상관없음
    public GameObject prefab;
}