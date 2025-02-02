using UnityEngine;

public class movement : MonoBehaviour
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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        movimientoPlano();     
    }

    private void movimientoPlano()
    {
        float losX = Input.GetKey(KeyCode.LeftArrow) ? 1 : Input.GetKey(KeyCode.RightArrow) ? -1 : 0;
        float losY = Input.GetKey(KeyCode.DownArrow) ? 1 : Input.GetKey(KeyCode.UpArrow) ? -1 : 0;
        
        float mouseX = losX * sensibilidad * Time.deltaTime;
        float mouseY = losY * sensibilidad * Time.deltaTime;

        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX, -limiteY, limiteY);

        rotacionY -= mouseX;
        rotacionY = Mathf.Clamp(rotacionY, -limiteX, limiteX);
        
        referencia.MoveRotation(Quaternion.Euler(rotacionX, 0f, rotacionY));
    }
}
