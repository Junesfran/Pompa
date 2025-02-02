using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class objetivo : MonoBehaviour
{
    public TextMeshProUGUI tPuntos;
    public TextMeshProUGUI tNivel;
    
    private int monedas;
    public int mLimite;
    public int nivel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        monedas = 0;
        tNivel.text = "Nivel: " + nivel;
        tPuntos.text = "Puntos: " + monedas + "/" + mLimite;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("Finish"))
        {
            
            if(nivel == 1)
            {
                SceneManager.LoadScene("nivel1");
            }
            else if (nivel == 2)
            {
                SceneManager.LoadScene("nivel2");
            }
            else if(nivel == 3)
            {
                Application.Quit();
            }

            //tNivel.text = "Nivel: "+nivel;

        }
        else if (colision.gameObject.CompareTag("Moneda"))
        {
            monedas++;
            tPuntos.text = "Puntos: " + monedas+"/"+mLimite;
        }
        
    }
}
