using UnityEngine;

/// <summary>
/// ICommand	실행과 취소를 위한 인터페이스
/// MoveCommand	유닛 이동 명령을 구현하는 커맨드 클래스
/// Unit	명령을 실제로 수행하는 대상 (수신자)
/// CommandInvoker	명령을 실행하고 되돌릴 수 있도록 저장 
/// </summary>
public class UnitController : MonoBehaviour
{
    private Unit _unit;
    private CommandInvoker _invoker;

    private void Start()
    {
        _unit = new Unit();
        _invoker = new CommandInvoker();

        Vector3 startPos = new Vector3(0, 0, 0);
        Vector3 moveTo = new Vector3(5, 0, 0);

        ICommand moveCommand = new MoveCommand(_unit, moveTo, startPos);
        _invoker.ExecuteCommand(moveCommand);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _invoker.UndoCommand();
        }
    }
}
