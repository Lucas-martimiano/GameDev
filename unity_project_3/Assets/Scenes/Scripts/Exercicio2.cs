using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int idade;

    void Start()
    {
        if (idade >= 18)
            Debug.Log("Maior de Idade");
        else
            Debug.Log("Menor de Idade");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
