using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool temArma = true;
        bool temMunicao = false;
        if (temArma && temMunicao)
            print("Pode Atirar");
        else
            print("Não pode Atirar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
