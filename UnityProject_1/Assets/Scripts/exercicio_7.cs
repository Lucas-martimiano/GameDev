using UnityEngine;

public class exercicio_7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int numero1,numero2;
    void Start()
    {
        Debug.Log("SOMA: " + (numero1 + numero2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
