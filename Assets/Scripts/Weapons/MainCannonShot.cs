using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCannonShot : MonoBehaviour {

    [SerializeField] private float rotationSpeed = 90f;
    private Coroutine rotationCoroutine;

    void Update() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            var touchWordPostion = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if (touchWordPostion.y > -3.5) {
                RotateToNewPosition(touchWordPostion);
            }
        }
    }

    private void RotateToNewPosition(Vector2 touchPostion) {
        var newAngle = CalculateBarrelAngel(touchPostion);
        Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
        float angularSpeed = Quaternion.Angle(transform.rotation, rotation) / rotationSpeed;
        if (rotationCoroutine != null) StopCoroutine(rotationCoroutine);
        rotationCoroutine = StartCoroutine(RotateCoroutine(rotation, angularSpeed));
    }
    private float CalculateBarrelAngel(Vector2 newPosion) {
        var calculated = Mathf.Atan2(newPosion.y - transform.position.y, newPosion.x - transform.position.x) * Mathf.Rad2Deg;
        return calculated - 90;
    }

    private IEnumerator RotateCoroutine(Quaternion targetRotation, float angularSpeed) {
        float elapsedTime = 0f;

        while (elapsedTime < angularSpeed) {
            float t = elapsedTime / angularSpeed;
            Quaternion newRotation = Quaternion.Lerp(transform.rotation, targetRotation, t);
            transform.rotation = newRotation;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.rotation = targetRotation;
    }
}
