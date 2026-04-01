using UnityEngine;

public class Exercicio_5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int qntMoedasBronze, qntMoedasPrata, qntMoedasOuro;
    [SerializeField] private int valorMoedasBronze = 1, valorMoedasPrata = 5, valorMoedasOuro = 10;
    void Start()
    {
        int valorColetado = (qntMoedasBronze * valorMoedasBronze) + (qntMoedasPrata * valorMoedasPrata) + (qntMoedasOuro * valorMoedasOuro);
        print("Valor Coletado na Fase: " + valorColetado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
