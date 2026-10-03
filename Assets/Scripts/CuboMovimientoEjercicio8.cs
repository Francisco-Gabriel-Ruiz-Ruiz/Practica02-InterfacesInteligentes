using UnityEngine;
using UnityEngine.UIElements;

public class CuboMovimientoEjercicio8 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;

    void Start() {
        // La velocidad inicial debe ser mayor que 1
        if (speed <= 1f) {
            speed = 1.1f;
        }
        // La posición del objeto debe estar en y=0
        if (transform.position.y != 0) {
            Vector3 previousPosition = transform.position;
            transform.position = new Vector3(previousPosition.x, 0f, previousPosition.z);
        }
    }

    void Update() {
        transform.Translate(moveDirection.x, moveDirection.y, moveDirection.z);
    }
}
