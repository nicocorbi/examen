using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField] public float velocidad = 0f;
    public Transform personaje;
    public Transform personaje2;

    void Start()
    {
        personaje.transform.position = Vector3.zero;
    }

    void Update()
    {
        MoverPersonaje(KeyCode.UpArrow, Vector3.up, KeyCode.W, Vector3.down);
        MoverPersonaje(KeyCode.DownArrow, Vector3.down, KeyCode.S, Vector3.up);
        MoverPersonaje(KeyCode.RightArrow, Vector3.right, KeyCode.D, Vector3.left);
        MoverPersonaje(KeyCode.LeftArrow, Vector3.left, KeyCode.A, Vector3.right);
    }

    private void MoverPersonaje(KeyCode tecla1, Vector3 direccion1, KeyCode tecla2, Vector3 direccion2)
    {
        if (Input.GetKey(tecla1))
        {
            personaje.position += direccion1 * velocidad * Time.deltaTime;
            personaje2.position += direccion1 * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(tecla2))
        {
            personaje.position += direccion1 * velocidad * Time.deltaTime;
            personaje2.position += direccion2 * velocidad * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CambiarColor(collision, Color.green);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CambiarColor(collision, collision.CompareTag("puntoRojo") ? Color.red : Color.blue);
    }

    private void CambiarColor(Collider2D collision, Color color)
    {
        if (collision.CompareTag("puntoRojo") && gameObject.CompareTag("personaje2"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
        else if (collision.CompareTag("puntoAzul") && gameObject.CompareTag("personaje1"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }
}
