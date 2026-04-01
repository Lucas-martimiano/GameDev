using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int energia = 30;
    void Start()
    {
        if (energia < 20)
            print("Sem energia suficiente");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
