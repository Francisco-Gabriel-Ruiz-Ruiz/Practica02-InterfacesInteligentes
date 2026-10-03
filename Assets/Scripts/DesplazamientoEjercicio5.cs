using UnityEngine;

public class DesplazamientoEjercicio5 : MonoBehaviour
{
    public GameObject marcadorInvisible;
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;

    void Start() {
        posicionOriginal = transform.position;
        // Establecer el desplazamiento por defecto
        desplazamiento = marcadorInvisible.transform.position - this.transform.position;
    }

    void Update() {
        if (Input.GetAxis("Jump") > 0) {
            // Aseguramos que no se desplaza infinitamente
            this.transform.position = posicionOriginal + desplazamiento;
        }
    }
}
