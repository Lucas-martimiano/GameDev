using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int numero;
    void Start()
    {
        if (numero % 2 == 1)
            Debug.Log("O número é impar");
        else
            Debug.Log("O número e par");
    }


     // Update is called once per frame
     void Update()
     {

     }
}
