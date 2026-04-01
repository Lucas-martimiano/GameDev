using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int moedas = 50;

    void Start()
    {
        if (moedas >= 100)
            print("Pode comprar Item");
        else
            print("Sem dinheiro suficiente");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
