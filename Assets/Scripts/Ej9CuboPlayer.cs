using UnityEngine;

public class Ej9CuboPlayer : MonoBehaviour
{
    public float speed;

    void Start() {
        // La velocidad inicial debe ser mayor que 1
        // if (speed <= 1f) {
        //     speed = 1.1f;
        // }
    }

    void Update() {
        float horizontalArrowsAxis = Input.GetAxis("HorizontalArrows");
        transform.Translate(horizontalArrowsAxis * speed, 0, 0);
        float verticalArrowsAxis = Input.GetAxis("VerticalArrows");
        transform.Translate(0, verticalArrowsAxis * speed, 0);
    }
}
