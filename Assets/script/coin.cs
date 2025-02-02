using UnityEngine;

public class coin : MonoBehaviour
{

    public GameObject objeto;
    public float velocidad = 50f;

    private Transform movi;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movi = objeto.transform;
    }

    // Update is called once per frame
    void Update()
    {
        movi.Rotate(Vector3.forward*velocidad*Time.deltaTime);
        if (objeto.CompareTag("Finish"))
        {
            movi.Rotate(Vector3.right * velocidad * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            if (!objeto.CompareTag("Finish"))
            {
                Destroy(objeto);
            }
        }
    }
}
