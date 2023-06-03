using UnityEngine;
using TMPro;

public class PanelManager : Singleton<PanelManager> {

    private PanelModel model;
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private TMP_Text header; 
    [SerializeField] private GameObject tilesContainer;


    public void GeneratePanel(PanelModel model) {
        this.model = model;
        header.text = model.PanelHeader;

        foreach(TileModel tile in model.Tiles) {
            Instantiate(tilePrefab, Vector3.zero, Quaternion.identity, tilesContainer.transform);
        }
    }

    private void ClearTiles() {
        tilesContainer.Chi
    }

}
