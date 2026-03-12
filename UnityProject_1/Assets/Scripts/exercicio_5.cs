using UnityEngine;

public class exercicio_5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int a, b;
    void Start()
    {
        Debug.Log("Resultado do Módulo: " + (a % b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
