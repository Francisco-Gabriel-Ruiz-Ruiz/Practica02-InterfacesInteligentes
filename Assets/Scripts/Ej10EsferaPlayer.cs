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
        float moveStep = speed * Time.deltaTime;
        float horizontalMove = Input.GetAxis("HorizontalAD") * moveStep;
        transform.Translate(horizontalMove * speed, 0, 0);
        float verticalMove = Input.GetAxis("VerticalWS") * moveStep;
        transform.Translate(0, verticalMove * speed, 0);
    }
    
}
