using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class PanelModel {
    public string PanelId;
    public string PanelHeader;

    public List<TileModel> Tiles = new List<TileModel>();

    public void AddTile(TileModel tile) {
        Tiles.Add(tile);
    }

}
