using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform center; // Objeto alrededor del cual rotar�
    public float speed = 10f; // Velocidad de rotaci�n
    public float radius = 2f; // Radio de la �rbita
    public bool selfRotate = false; // Define si el objeto rota sobre su propio eje

    private float angle;

    void Update()
    {
        if (center != null)
        {
            angle = speed * Time.time; // Usamos Time.time para mantener una velocidad constante sin aceleraci�n
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;
            transform.position = new Vector3(center.position.x + x, center.position.y + y, 0);
        }

        if (selfRotate)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime); // Hace que el objeto rote sobre s� mismo
        }
    }
}


