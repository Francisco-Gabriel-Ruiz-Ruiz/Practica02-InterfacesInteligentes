using UnityEngine;

public class Ej5Desplazamiento : MonoBehaviour
{
    public GameObject marcadorInvisible;
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;

    void Start() {
        posicionOriginal = transform.position;
        // Establecer el desplazamiento por defecto
        desplazamiento = marcadorInvisible.transform.position - transform.position;
    }

    void Update() {
        if (Input.GetAxis("Jump") > 0) {
            // Aseguramos que no se desplaza infinitamente
            transform.position = posicionOriginal + desplazamiento;
        }
    }
}
