using UnityEngine;

public class controlmovile : MonoBehaviour
{
    //La referencia es el plano
    public Rigidbody referencia;
    //Default 100, lo ire ajustando
    public float sensibilidad = 100f;
    //Default 80, es publico lo ire ajustando
    public float limiteX = 80f;
    public float limiteY = 80f;


    private float rotacionX = 0f;
    private float rotacionY = 0f;

    private Gyroscope giroscopio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            giroscopio = Input.gyro;
            giroscopio.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        movimientoPlano();
    }

    private void movimientoPlano()
    {
        // Obtener la rotación del giroscopio
        Quaternion rotacionGiro = giroscopio.attitude;

        // Ajustar la rotación al sistema de coordenadas de Unity
        rotacionGiro = new Quaternion(rotacionGiro.x, rotacionGiro.y, -rotacionGiro.z, -rotacionGiro.w);

        // Aplicar la rotación al plano
        referencia.rotation = rotacionGiro;

    }
}
