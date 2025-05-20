using UnityEngine;


// 사운드 시스템
public class SoundManager
{
    public void Initialize() => Debug.Log("사운드 초기화");
}

// 데이터 시스템
public class DataManager
{
    public void LoadData() => Debug.Log("게임 데이터 불러오기");
}

// 씬 로더
public class SceneLoader
{
    public void LoadScene(string sceneName) => Debug.Log($"{sceneName} 씬 로딩");
}

// UI 초기화
public class UIManager
{
    public void SetupUI() => Debug.Log("UI 초기화");
}

public class GameLoader
{
    //해당 new로 매니저를 생성하는 것은 예시 코드로 해놓은 것이고, 만약 이미 씬에 해당 매니저가 있으면 
    //힙 메모리에 올라가있을 것이고, 여기서 new로 다시 생성하면 중복으로 힙 메모리에 올라가기 때문에 new 하면 안된다.
    
    //각 매니저는 싱글톤화로 되어있고, LoadGame에서 Singleton으로 참조 되어있는 것을 접근하는 방법일 것이다.
    
    private SoundManager soundManager = new SoundManager();
    private DataManager dataManager = new DataManager();
    private SceneLoader sceneLoader = new SceneLoader();
    private UIManager uiManager = new UIManager();

    public void LoadGame()
    {
        soundManager.Initialize();
        dataManager.LoadData();
        sceneLoader.LoadScene("InGame");
        uiManager.SetupUI();
        Debug.Log("게임 로딩 완료!");
    }
}

public class Facade : MonoBehaviour
{
    private void Awake()
    {
        GameLoader gameLoader = new GameLoader();
        gameLoader.LoadGame();
    }
}
