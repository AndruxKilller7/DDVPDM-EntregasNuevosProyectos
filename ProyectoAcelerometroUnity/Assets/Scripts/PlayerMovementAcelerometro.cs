using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementAcelerometro : MonoBehaviour
{
    public float velocidad;
    Rigidbody2D rbPlayer;
    public GameObject panelGameOver;
    public Text contador;
    public int cantidad;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        
    }

   
    void Update()
    {
        contador.text = cantidad.ToString();
        Vector3 acelerometroVector = new Vector3(Input.acceleration.x, Input.acceleration.y, 0);

        transform.Translate(acelerometroVector * velocidad * Time.deltaTime);

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        //}

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pato"))
        {
            panelGameOver.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (collision.CompareTag("Star"))
        {
            cantidad += 1;
        }
    }


    public void Continuar()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
