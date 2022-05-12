using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrellas : MonoBehaviour
{
    public float velocidad;
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector3.down* velocidad * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Limite"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
