using UnityEngine;

public class Ej13EsferaControlZ : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Start() {
    
    }

    void Update() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        // Rotación
        float rotationHorizontalAxisValue = horizontalAxis * turnSpeed * Time.deltaTime;
        transform.Rotate(transform.up * rotationHorizontalAxisValue);
        // Avance
        Vector3 forwardMovement = transform.forward * speed * Time.deltaTime;
        transform.Translate(forwardMovement);
    }
}
