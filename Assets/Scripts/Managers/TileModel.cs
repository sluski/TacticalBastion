using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileModel {
    public string title;
    public Sprite image;
    public bool active;
    public int priority;

    public TileModel(string title, Sprite image, bool active, int priority) {
        this.title = title;
        this.image = image;
        this.active = active;
        this.priority = priority;
    }

}
