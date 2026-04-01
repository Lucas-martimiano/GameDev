using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float velocidade = 5f;
    
    void Start()
    {
        if (velocidade > 10)
            print("Muito Rapido");
        else
            print("Velocidade Normal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
