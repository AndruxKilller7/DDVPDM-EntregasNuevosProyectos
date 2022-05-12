using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorDeObjetos : MonoBehaviour
{
  
    public GameObject estrella;
    public float tiempoDeInstanciacion;
    float posX;
    void Start()
    {
        
    }

    
    void Update()
    {
        posX = Random.Range(-4, 4);
        tiempoDeInstanciacion += 1f * Time.deltaTime;
        if(tiempoDeInstanciacion>=1f)
        {
            Instantiate(estrella, new Vector3(posX,transform.position.y-2f,transform.position.z), estrella.transform.rotation);
            tiempoDeInstanciacion = 0.0f;
        }
    }
}
