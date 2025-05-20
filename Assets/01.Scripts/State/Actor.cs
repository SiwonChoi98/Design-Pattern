using System;
using Unity.VisualScripting;
using UnityEngine;

public class Actor : MonoBehaviour
{
    private StateMachine<Actor> _stateMachine;

    private void AddState()
    {
        _stateMachine = new StateMachine<Actor>(this, new FirstState());
        _stateMachine.AddState(new SecondState());
    }

    private void ChangeState(int num)
    {
        switch (num)
        {
            case 1:
                _stateMachine.ChangeState<FirstState>();
                break;
            case 2:
                _stateMachine.ChangeState<SecondState>();
                break;
        }
    }

    private void Start()
    {
        AddState();
    }
    private void Update()
    {
        _stateMachine.Update(Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeState(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeState(2);
        }
    }
    
    
}
