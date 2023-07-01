using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Vector2 targetPosition;
    private Vector2 startPosition;

    private float elapsedTime;

    private float moveTime;
    private Coroutine movingCoroutine;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float movementLevel = -7;
    private bool canMove;

    void Update() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            StartMoving();
        }
    }

    private void StartMoving() {
        var touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        if (IsPointInMovingArea(touchPos)) {
            startPosition = transform.position;
            targetPosition = touchPos;
            elapsedTime = Vector2.Distance(startPosition, targetPosition) / (10 * speed);
            moveTime = 0;
            StartCoroutine();
        }
    }

    private bool IsPointInMovingArea(Vector2 point) {
        return point.y < movementLevel;
    }

    private void StartCoroutine() {
        if (movingCoroutine != null) {
            StopCoroutine(movingCoroutine);
        }
        movingCoroutine = StartCoroutine(MoveObject());
    }

    private IEnumerator MoveObject() {
        while (moveTime < elapsedTime) {
            transform.position = Vector2.Lerp(startPosition, targetPosition, moveTime / elapsedTime);
            moveTime += Time.deltaTime;
            yield return null;
        }
    }
}
