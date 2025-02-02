using UnityEngine;

public class musica : MonoBehaviour
{
    public AudioClip cancion; 
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        // Configurar el AudioSource
        audioSource.clip = cancion;
        audioSource.loop = true; 
        audioSource.playOnAwake = true;
        audioSource.volume = 0.5f; 
        DontDestroyOnLoad(gameObject);

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
