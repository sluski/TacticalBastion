using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInstanceModel : MonoBehaviour
{
    public string PanelId;
    public GameObject PanelInstance;

    public PanelInstanceModel(string panelId, GameObject panelInstance) {
        PanelId = panelId;
        PanelInstance = panelInstance;
    }
}
