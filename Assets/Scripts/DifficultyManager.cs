using UnityEngine;

public class DifficultyManager : MonoBehaviour {

    public DifficultySettings CurrentDifficulty;

    private void LoadDifficulty(DifficultySettings difficultySettings) {
        CurrentDifficulty = difficultySettings;
    }
}