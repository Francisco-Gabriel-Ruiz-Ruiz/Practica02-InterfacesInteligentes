using UnityEngine;

public class Ej10EsferaPlayer : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, translation, 0);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(0, -translation, 0);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-translation, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(translation, 0, 0);
        }
    }
    
}
