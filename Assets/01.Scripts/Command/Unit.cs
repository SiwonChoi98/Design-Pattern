using UnityEngine;

public class Unit
{
    public void Move(Vector3 position)
    {
        Debug.Log($"유닛이 {position} 위치로 이동합니다.");
    }

    public void MoveBack(Vector3 previousPosition)
    {
        Debug.Log($"유닛이 이전 위치 {previousPosition}로 되돌아갑니다.");
    }
}