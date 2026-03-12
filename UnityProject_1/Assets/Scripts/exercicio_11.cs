using UnityEngine;

public class exercicio_11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidadeInicial, aceleracao, tempo;
    void Start()
    {
        float velocidadeFinal = velocidadeInicial + aceleracao * tempo;
        Debug.Log("Velocidade: " + velocidadeFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
