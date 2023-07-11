using UnityEngine;
using System.Collections.Generic;

public class WaweManager : MonoBehaviour {

    public WaweLoadEvent OnWaweLoad;

    public List<Wawe> Wawes = new List<Wawe>();

    private int currentWaweIndex = 0;

    public bool WaweCompleted = true;

    public void LoadNextWawe() {
        LoadWawe(Wawes[currentWaweIndex]);
        currentWaweIndex += 1;
    }

    private void LoadWawe(Wawe wawe) {
        OnWaweLoad.Invoke(wawe);
    }

}