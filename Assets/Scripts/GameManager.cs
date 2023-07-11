using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public DifficultySettings CurrentDifficulty;

    public WaweLoadEvent OnWaweLoad;

    public Wawe wawe;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start() {
        LoadWawe(wawe);
    }

    public void LoadWawe(Wawe wawe) {
        OnWaweLoad.Invoke(wawe);
    }

    public void LoadDifficulty(DifficultySettings difficultySettings) {
        CurrentDifficulty = difficultySettings;
    }
    

}
