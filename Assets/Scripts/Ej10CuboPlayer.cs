using UnityEngine;

public class Ej10CuboPlayer : MonoBehaviour
{
    public float speed;

    void Start() {
        // La velocidad inicial debe ser mayor que 1
        // if (speed <= 1f) {
        //     speed = 1.1f;
        // }
    }

    void Update() {
        float translation = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, translation, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(0, -translation, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-translation, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(translation, 0, 0);
        }
    }
}
