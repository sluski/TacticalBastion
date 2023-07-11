using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public WaweManager WaweManager;
    public DifficultyManager DifficultyManager;


    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        WaweManager = GetComponent<WaweManager>();
        DifficultyManager = GetComponent<DifficultyManager>();
    }

}
