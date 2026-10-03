using UnityEngine;

public class EsferaPlayerEjercicio9 : MonoBehaviour
{
    public float speed;

    void Start() {
        // La velocidad inicial debe ser mayor que 1
        // if (speed <= 1f) {
        //     speed = 1.1f;
        // }
    }

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(speed, 0, 0);
        }
    }
}
