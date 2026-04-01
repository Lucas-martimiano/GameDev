using UnityEngine;

public class Exercicio13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool temChave = false;
        bool portaDestravada = true;
        if (temChave || portaDestravada)
            print("Acesso Permitido");
        else
            print("Sem Acesso");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
