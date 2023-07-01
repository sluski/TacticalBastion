using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCannonShot : MonoBehaviour {

    [SerializeField] private float rotationSpeed = 90f;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform projectilesContainer;
    private Coroutine rotationCoroutine;

    void Update() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            var touchWordPostion = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if (touchWordPostion.y > -3.5) {
                RotateToNewPosition(touchWordPostion);
                Shoot(touchWordPostion);
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

    private void Shoot(Vector2 touchPosition) {
        var shootDirection = new Vector2(touchPosition.x, Mathf.Abs(touchPosition.y)).normalized;
        var obj = Instantiate(projectile, firePoint.position, Quaternion.identity, projectilesContainer);
        var controller = obj.GetComponent<MainCannonProjectile>();
        if(controller != null) {
            controller.Initialize(shootDirection);
        }else {
            throw new System.Exception("Projectile does not extends Projectile class");
        }
    }
}
