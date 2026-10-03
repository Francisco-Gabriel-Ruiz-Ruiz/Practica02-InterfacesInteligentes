using UnityEngine;

public class Ej13EsferaControlZ : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Start() {
    
    }

    void Update() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float horizontalSpeedAxisValue = horizontalAxis * speed * Time.deltaTime;
        float horizontalRotationAxisValue = horizontalAxis * turnSpeed * Time.deltaTime;
        transform.Rotate(transform.forward * horizontalRotationAxisValue);
        if (horizontalSpeedAxisValue < 0f) { // Siempre avanza hacia delante
            horizontalSpeedAxisValue = -horizontalSpeedAxisValue;
        }
        transform.Translate(0, 0, horizontalSpeedAxisValue);
    }
}
