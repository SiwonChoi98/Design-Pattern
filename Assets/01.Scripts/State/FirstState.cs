using UnityEngine;

public class FirstState : State<Actor>
{
    public override void OnInitialized()
    {
        
    }

    public override void OnEnter()
    {
        Debug.Log("FirstState.OnEnter");
    }

    public override void Update(float deltaTime)
    {
    }

    public override void OnExit()
    {
        
    }
}
