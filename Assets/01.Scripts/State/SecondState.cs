using UnityEngine;

public class SecondState : State<Actor>
{
    public override void OnInitialized()
    {
        
    }

    public override void OnEnter()
    {
        Debug.Log("SecondState.OnEnter");
    }

    public override void Update(float deltaTime)
    {
        
    }

    public override void OnExit()
    {
        
    }
}
