using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giroscopio : MonoBehaviour
{
    public bool giroscopioHabilitado;
    private Gyroscope giroscopio;
    private GameObject contenedorDeCamara;
    private Quaternion rotacion;

    void Start()
    {
        contenedorDeCamara = new GameObject("CameraContainer");
        contenedorDeCamara.transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        transform.SetParent(contenedorDeCamara.transform);
     
        giroscopioHabilitado = HabilitandoGiroscopio();
    }

    
    void Update()
    {
        if (giroscopioHabilitado)
        {
            transform.localRotation = giroscopio.attitude * rotacion;
        }
    }

    private bool HabilitandoGiroscopio()
    {
        if(SystemInfo.supportsGyroscope)
        {
            giroscopio = Input.gyro;
            giroscopio.enabled=true;

            contenedorDeCamara.transform.rotation = Quaternion.Euler(90f, 90f, 0);
            rotacion = new Quaternion(0, 0, 1, 0);
            return true;

        }

        return false;
    }
}
