using UnityEngine;

public class Ej9EsferaPlayer : MonoBehaviour
{
    public float speed;

    void Start() {
        // La velocidad inicial debe ser mayor que 1
        // if (speed <= 1f) {
        //     speed = 1.1f;
        // }
    }

    void Update() {
        float horizontalADAxis = Input.GetAxis("HorizontalAD");
        transform.Translate(horizontalADAxis * speed, 0, 0);
        float verticalWSAxis = Input.GetAxis("VerticalWS");
        transform.Translate(0, verticalWSAxis * speed, 0);
    } 
}
