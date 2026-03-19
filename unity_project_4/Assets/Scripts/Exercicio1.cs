using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int vida = 100;

    void Start()
    {
        if (vida <= 0)
            print("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
