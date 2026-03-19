using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int pontos;

    void Start()
    {
        if (pontos >= 100)
            print("Você venceu!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
