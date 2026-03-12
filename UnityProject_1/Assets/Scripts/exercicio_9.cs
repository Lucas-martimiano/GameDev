using UnityEngine;

public class exercicio_9 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int numero;
    void Start()
    {
        Debug.Log("Dobro: " + (numero * 2));
        Debug.Log("Metade: " + (numero / 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
