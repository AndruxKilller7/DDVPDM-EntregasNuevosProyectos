using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorDePatos : MonoBehaviour
{
    public GameObject pato;
    public float tiempoDeInstanciacion;
    float posY;
    void Start()
    {

    }


    void Update()
    {
        posY = Random.Range(-2, 4);
        tiempoDeInstanciacion += 1f * Time.deltaTime;
        if (tiempoDeInstanciacion >= 5f)
        {
            Instantiate(pato, new Vector3( transform.position.x, posY, transform.position.z), transform.rotation);
            tiempoDeInstanciacion = 0.0f;
        }
    }
}
