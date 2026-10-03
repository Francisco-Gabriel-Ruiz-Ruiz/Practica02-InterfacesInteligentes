using System.Globalization;
using System.ComponentModel;
using UnityEngine;

public class CampoVelocidadEjercicio6 : MonoBehaviour
{
    public float speed = 1;

    void Start() {

    }

    void Update() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float horizontalAxisValue = horizontalAxis * speed;

        float verticalAxis = Input.GetAxis("Vertical");
        float verticalAxisValue = verticalAxis * speed;

        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Flecha izquierda con valor del eje horizontal: " + horizontalAxisValue.ToString("F2", CultureInfo.InvariantCulture));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Flecha derecha con valor del eje horizontal: " + horizontalAxisValue.ToString("F2", CultureInfo.InvariantCulture));
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Flecha arriba con valor del eje vertical: " + verticalAxisValue.ToString("F2", CultureInfo.InvariantCulture));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Flecha abajo con valor del eje vertical: " + verticalAxisValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
