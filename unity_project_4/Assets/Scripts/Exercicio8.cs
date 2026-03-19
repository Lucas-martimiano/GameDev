using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int nivelJogador = 5;
    int nivelInimigo = 8;
    void Start()
    {
        if (nivelJogador >= nivelInimigo)
            print("Pode Lutar");
        else
            print("Muito Perigoso");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
