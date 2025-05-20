using UnityEngine;

public class MoveCommand : ICommand
{
    private Unit _unit;
    private Vector3 _targetPosition;
    private Vector3 _previousPosition;

    public MoveCommand(Unit unit, Vector3 targetPosition, Vector3 previousPosition)
    {
        _unit = unit;
        _targetPosition = targetPosition;
        _previousPosition = previousPosition;
    }

    public void Execute()
    {
        _unit.Move(_targetPosition);
    }

    public void Undo()
    {
        _unit.MoveBack(_previousPosition);
    }
}