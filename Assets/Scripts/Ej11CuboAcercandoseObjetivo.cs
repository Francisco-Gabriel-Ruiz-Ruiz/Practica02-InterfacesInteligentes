using UnityEngine;
using UnityEngine.UIElements;

public class Ej11CuboAcercandoseObjetivo : MonoBehaviour
{
    public GameObject target;
    public float speed;

    private Transform targetTransform;

    void Start() {
        if (!target) {
            Debug.LogError("Error: ¡no se ha definido un objeto hacia el que moverse!");
            return;
        }
        targetTransform = target.transform;
    }

    void Update() {
        if (!target) {
            return;
        }
        Vector3 targetPosition = targetTransform.position;
        Vector3 moveDirection = new Vector3(targetPosition.x - transform.position.x, 0, targetPosition.z - transform.position.z);
        Vector3 normalizedMoveDirection = moveDirection.normalized;
        float translation = speed * Time.deltaTime;
        transform.Translate(normalizedMoveDirection * translation);
    }
}
