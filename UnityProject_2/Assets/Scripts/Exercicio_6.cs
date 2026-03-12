using UnityEngine;

public class Exercicio_6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float distancia = 120f, tempo = 10f;
    void Start()
    {
        float velocidadeMedia = distancia / tempo;
        print("Velocidade Média: " +  velocidadeMedia.ToString("F2") + " metros/segundo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
