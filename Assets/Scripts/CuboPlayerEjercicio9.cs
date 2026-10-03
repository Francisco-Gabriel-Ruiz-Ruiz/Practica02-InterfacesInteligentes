using UnityEngine;

public class CuboPlayerEjercicio9 : MonoBehaviour
{
    public float speed;

    void Start() {
        // La velocidad inicial debe ser mayor que 1
        // if (speed <= 1f) {
        //     speed = 1.1f;
        // }
    }

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(speed, 0, 0);
        }
    }
}
