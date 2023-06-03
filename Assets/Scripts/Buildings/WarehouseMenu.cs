using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseMenu : MonoBehaviour {

    private PanelModel panelModel;

    void Start() {
        panelModel = new PanelModel();
        panelModel.PanelHeader = "Testowy header";
        panelModel.PanelId = "1";
        panelModel.Tiles.Add(new TileModel("tile 1", null, true, 1));
        panelModel.Tiles.Add(new TileModel("tile 2", null, true, 2));
        panelModel.Tiles.Add(new TileModel("tile 3", null, true, 3));
    }
    public void Test() {
        Debug.Log("Displaying panel");
        PanelManager.Instance.GeneratePanel(panelModel);
    }
}
