using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        int danoBase = 10;
        bool critico = true;

        if (critico)
        {
            danoBase *= 2;
            print("Dano Base: " +  danoBase);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
