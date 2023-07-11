using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWaweButton : MonoBehaviour {

    private Image spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<Image>();
    }

    private void Update() {
        if(GameManager.Instance.WaweManager.WaweCompleted) {
            spriteRenderer.enabled = true;
        } else {
            spriteRenderer.enabled = false;
        }
    }
}
